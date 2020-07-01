using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AGMPOP.BL.CoreBL;
using AGMPOP.BL.Helpers;
using AGMPOP.BL.Models.Domain;
using AGMPOP.BL.Models.ViewModels;
using AGMPOP.Web.Auth;
using AGMPOP.Web.Models;
using AGMPOP.Web.Models.UserManagement;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AGMPOP.Web.Controllers
{
    [AppAuthorize]
    public class UserManagementController : BaseController
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly IConfiguration Configuration;
        public UserManagementController(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            UnitOfWork = unitOfWork;
            Configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult _UserList(UserSC search)
        {
            if (!LoggedIsSystemAdmin)
            {
                search.Department.Add(LoggedUserDepartmentId);
            }

            var users = UnitOfWork.AppUserBL.SearchUsers(search);
            var model = users.Select(u =>
            {
                var roles = UnitOfWork.RoleBL.GetUserRoles(u.Id);
                return new UserVM(u)
                {
                    Roles = string.Join(", ", roles.Select(r => r.Name).ToArray()),
                };
            }).ToList();
            return PartialView(model);
        }

        public IActionResult CreateUser()
        {
            ViewBag.Title = "Create User";
            return View(new AddUserDto());
        }

        public IActionResult UpdateUser(int id)
        {
            ViewBag.Title = "Update User";
            var model = UnitOfWork.AppUserBL.GetUserWithDetails(id);
            return View("CreateUser", new AddUserDto(model));
        }

        [HttpPost]
        public JsonResult CreateUser(AddUserDto model)
        {
            if (!ModelState.IsValid)
            {
                return Json(null);
            }
            else
            {
                var selectedIds = new List<int>();
                if (!string.IsNullOrEmpty(model.SelectedTerritories))
                {
                    selectedIds = model.SelectedTerritories
                                       .Split(',', StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToList();
                }
                var user = new AppUser
                {
                    PasswordHash = PEncryption.Encrypt(model.Password),
                    FullName = model.Name,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber,
                    JobTitleId = model.JobTitle,
                    IsActive = model.IsActive,
                    DepartmentId = model.Department, // edit mo salah

                };

                if (UnitOfWork.AppUserBL.ValidateUser(user, out string errorMessage))
                {
                    var allTerritories = UnitOfWork.TerritoriesBL.GetAllActive();

                    var selectedTerritories = allTerritories.Where(t => selectedIds.Contains(t.TerritoryId)).ToList();
                    var grantedTerritories = new List<Territories>();
                    for (int i = 0; i < selectedTerritories.Count; i++)
                    {
                        var territory = selectedTerritories[i];
                        GetParentTerritories(territory, allTerritories, ref grantedTerritories);
                    }

                    user.UserTerritory = grantedTerritories.Select(t => new UserTerritory
                    {
                        TerritoryId = t.TerritoryId
                    }).ToList();

                    user.LnkUserRole = model.Roles.Where(r => r.HasValue).Select(role => new LnkUserRole
                    {
                        RoleId = role.GetValueOrDefault(),
                    }).ToList();

                    user.CreatedBy = LoggedUserId;
                    user.CreationDate = DateTime.Now;

                    UnitOfWork.AppUserBL.Add(user);

                    if (UnitOfWork.Complete(LoggedUserId) > 0)
                    {
                        return Json(new
                        {
                            Success = true,
                            Message = "User added successfully",
                        });
                    }
                    else
                    {
                        return Json(new
                        {
                            Success = false,
                            Message = "Failed to add user",
                        });
                    }
                }
                else
                {
                    return Json(new
                    {
                        Success = false,
                        ModelError = errorMessage,
                    });
                }

            }
        }

        [HttpPost]
        public JsonResult UpdateUser(UserDto model)
        {
            if (!ModelState.IsValid)
            {
                return Json(null);
            }
            else
            {
                var selectedIds = new List<int>();
                if (!string.IsNullOrEmpty(model.SelectedTerritories))
                {
                    selectedIds = model.SelectedTerritories
                                       .Split(',', StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToList();
                }
                var user = UnitOfWork.AppUserBL.GetUserWithDetails(model.Id);

                user.FullName = model.Name;
                user.Email = model.Email;
                user.PhoneNumber = model.PhoneNumber;
                user.JobTitleId = model.JobTitle;
                user.DepartmentId = model.Department;
                user.IsActive = model.IsActive;
                if (UnitOfWork.AppUserBL.ValidateUser(user, out string errorMessage))
                {
                    user.LnkUserRole = model.Roles.Where(r => r.HasValue).Select(r => new LnkUserRole
                    {
                        RoleId = r.Value
                    }).ToHashSet();
                    user.LastModifiedBy = LoggedUserId;
                    user.LastModificationDate = DateTime.Now;

                    UnitOfWork.AppUserBL.Update(user);

                    var oldTerritories = UnitOfWork.TerritoriesBL
                                                   .GetAllByUserId(user.Id)
                                                   .ToList();

                    var allTerritories = UnitOfWork.TerritoriesBL
                                                   .GetAllActive()
                                                   .ToList();

                    var selectedTerritories = allTerritories.Where(t => selectedIds.Contains(t.TerritoryId)).ToList();
                    var grantedTerritories = new List<Territories>();
                    for (int i = 0; i < selectedTerritories.Count; i++)
                    {
                        var territory = selectedTerritories[i];
                        GetParentTerritories(territory, allTerritories, ref grantedTerritories);
                    }

                    var toRemove = oldTerritories.Except(grantedTerritories)
                                                 .Select(t => t.TerritoryId)
                                                 .ToList();

                    var toAdd = grantedTerritories.Except(oldTerritories)
                                                  .Select(t => t.TerritoryId)
                                                  .ToList();

                    UnitOfWork.AppUserBL.DetachTerritories(user.Id, toRemove);
                    UnitOfWork.AppUserBL.AttachTerritories(user.Id, toAdd);

                    if (UnitOfWork.Complete(LoggedUserId) > 0)
                    {
                        return Json(new
                        {
                            Success = true,
                            Message = "User updated successfully",
                        });
                    }
                    else
                    {
                        return Json(new
                        {
                            Success = false,
                            Message = "Failed to update user",
                        });
                    }
                }
                else
                {
                    return Json(new
                    {
                        Success = false,
                        ModelError = errorMessage,
                    });
                }
            }
        }

        [HttpPut]
        public JsonResult DeactivateUser(int id)
        {
            try
            {
                var user = UnitOfWork.AppUserBL.GetByID(id);
                if (user != null)
                {
                    user.IsActive = false;
                    user.LastModifiedBy = LoggedUserId;
                    user.LastModificationDate = DateTime.Now;

                    UnitOfWork.AppUserBL.Update(user);
                    if (UnitOfWork.Complete(LoggedUserId) > 0)
                    {
                        return Json(new
                        {
                            Success = true,
                            Message = "User deactivate successfully",
                        });
                    }
                    else
                    {
                        return Json(new
                        {
                            Success = false,
                            Message = "Failed to deactivate user",
                        });
                    }
                }
                else
                {
                    return Json(new
                    {
                        Success = false,
                        Message = "User not found",
                    });
                }
            }
            catch
            {
                return Json(new
                {
                    Success = false,
                    Message = "Failed to deactivate user",
                });
            }
        }

        [HttpPut]
        public JsonResult ActivateUser(int id)
        {
            try
            {
                var user = UnitOfWork.AppUserBL.GetByID(id);
                if (user != null)
                {
                    user.IsActive = true;
                    user.LastModifiedBy = LoggedUserId;
                    user.LastModificationDate = DateTime.Now;

                    UnitOfWork.AppUserBL.Update(user);
                    if (UnitOfWork.Complete(LoggedUserId) > 0)
                    {
                        return Json(new
                        {
                            Success = true,
                            Message = "User activate successfully",
                        });
                    }
                    else
                    {
                        return Json(new
                        {
                            Success = false,
                            Message = "Failed to activate user",
                        });
                    }
                }
                else
                {
                    return Json(new
                    {
                        Success = false,
                        Message = "User not found",
                    });
                }
            }
            catch
            {
                return Json(new
                {
                    Success = false,
                    Message = "Failed to activate user",
                });
            }
        }

        [PermissionNotRequired]
        public IActionResult ChangePassword(string returnUrl)
        {
            string email = LoggedUserEmail;
            if (string.IsNullOrEmpty(email))
            {
                return RedirectToAction("Logout", "Account");
            }
            ViewBag.returnUrl = returnUrl;
            ChangePasswordDto model = new ChangePasswordDto { Email = email };
            return View(model);
        }

        [HttpPost]
        [PermissionNotRequired]
        [ValidateAntiForgeryToken]
        public JsonResult ChangePassword(ChangePasswordDto model, string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            if (!ModelState.IsValid)
            {
                return Json(null);
            }
            if (UnitOfWork.AppUserBL.ChangePassword(model.Email, model.Password, model.NewPassword, out string errorMessage))
            {
                if (UnitOfWork.Complete(LoggedUserId) > 0)
                {
                    var redirect = returnUrl ?? "/";
                    return Json(new
                    {
                        Ok = true,
                        Message = "Password changed successully",
                        Redirect = redirect,
                    });
                }
                else
                {
                    return Json(new
                    {
                        Ok = false,
                        Message = "Failed to change password",
                    });

                }
            }
            else
            {
                return Json(new
                {
                    Ok = false,
                    Message = errorMessage,
                });
            }

        }

        [PermissionNotRequired]
        public PartialViewResult ResetPassword(int id)
        {
            ResetPasswordDto model = new ResetPasswordDto { Id = id };
            return PartialView("_ResetPassword", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult ResetPassword(ResetPasswordDto model)
        {
            if (!ModelState.IsValid)
            {
                return Json(null);
            }
            if (UnitOfWork.AppUserBL.ResetPassword(model.Id, model.Password, out string errorMessage))
            {
                if (UnitOfWork.Complete(LoggedUserId) > 0)
                {
                    return Json(new
                    {
                        Ok = true,
                        Message = "Password reset successully",
                    });
                }
                else
                {
                    return Json(new
                    {
                        Ok = false,
                        Message = "Failed to reset password",
                    });

                }
            }
            else
            {
                return Json(new
                {
                    Ok = false,
                    Message = errorMessage,
                });
            }
        }

        public FileResult ExportUsers(UserSC search)
        {
            var users = UnitOfWork.AppUserBL.SearchUsers(search);
            var allUsers = UnitOfWork.AppUserBL.GetAll();
            var data = users.Select(u =>
            {
                var roles = UnitOfWork.RoleBL.GetUserRoles(u.Id);
                return new UserExportModel(u)
                {
                    Roles = string.Join(", ", roles.Select(r => r.Name).ToArray()),
                    CreatedBy = allUsers.FirstOrDefault(p => p.Id == u.CreatedBy)?.FullName,
                    LastModifiedBy = allUsers.FirstOrDefault(p => p.Id == u.LastModifiedBy)?.FullName,
                };
            }).ToArray();

            if (data?.Length > 0)
            {
                var dt = Helper.GenerateDataTable(data);
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.Worksheets.Add(dt, "Users");
                    using (MemoryStream stream = new MemoryStream())
                    {
                        var now = DateTime.Now;
                        var sb = new StringBuilder();
                        sb.Append(now.ToShortDateString())
                          .Append('_')
                          .Append(now.ToShortTimeString());
                        var nowString = sb.ToString();
                        wb.SaveAs(stream);
                        return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", $"Users_{nowString}.xlsx");
                    }
                }
            }
            else
            {
                return null;
            }
        }

        [PermissionNotRequired]
        public JsonResult GetAllTerritories(int? userId = null)
        {
            var tree = new List<JsTreeVM>();

            var allTerritories = UnitOfWork.TerritoriesBL.GetAllActive();
            var grantedTerritories = UnitOfWork.TerritoriesBL.GetAllByUserId(userId.GetValueOrDefault());

            for (int i = 0; i < allTerritories.Count; i++)
            {
                var item = allTerritories[i];
                var node = new JsTreeVM
                {
                    Id = item.TerritoryId.ToString(),
                    State = new Models.TreeNodeStatus(),
                    Parent = "#",
                    Text = item.Name,
                };
                if (item.ParentId != null)
                {
                    node.Parent = item.ParentId.ToString();
                }
                if (grantedTerritories.Contains(item) && allTerritories.All(p => p.ParentId != item.TerritoryId))
                {
                    node.State.Opened = true;
                    node.State.Selected = true;
                }
                tree.Add(node);
            }
            return Json(new
            {
                Success = true,
                Data = tree
            });
        }

        private void GetParentTerritories(Territories territory, List<Territories> allTerritories, ref List<Territories> tree)
        {
            if (tree.Any(p => p.TerritoryId == territory.TerritoryId))
            {
                return;
            }
            tree.Add(territory);
            var parent = allTerritories.FirstOrDefault(p => p.TerritoryId == territory.ParentId);
            if (parent == null)
            {
                return;
            }
            GetParentTerritories(parent, allTerritories, ref tree);
        }

        public JsonResult testMethod()
        {
            UnitOfWork.UserClearanceBL.TestMethod(Configuration.GetConnectionString("AGMPOPContext"));
            return Json(null);
        }
    }
}
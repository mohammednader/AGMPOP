using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AGMPOP.BL.CoreBL;
using AGMPOP.BL.Models.Domain;
using AGMPOP.BL.Models.ViewModels;
using AGMPOP.Web.Auth;
using AGMPOP.Web.Models.Cycle;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static AGMPOP.BL.Models.ViewModels.POPEnums;

namespace AGMPOP.Web.Controllers
{
    [AppAuthorize]
    public class CyclesController : BaseController
    {
        private readonly IUnitOfWork UnitOfWork;

        public CyclesController(IUnitOfWork _unitOfWork)
        {
            UnitOfWork = _unitOfWork;
        }

        #region List

        public IActionResult List()
        {
            var _ = LoggedUserId;
            var terList = UnitOfWork.TerritoriesBL.InitTerritoies();
            var json = JsonConvert.SerializeObject(terList);

            ViewBag.TreeData = json;

            return View();
        }
        #endregion

        #region CyclesList

        [PermissionNotRequired]
        public PartialViewResult CyclesList()
        {

            try
            {
                List<Cycles> Result = null;
                if (LoggedIsSystemAdmin)
                {
                    Result = UnitOfWork.CyclesBL.GetCycleWithProduct(c => c.Department.IsActive == true);
                }
                else // normal user 
                {
                    Result = UnitOfWork.CyclesBL.GetCycleWithProduct(c => c.DepartmentId == LoggedUserDepartmentId);
                }

                var model = Result?.Select(f => new CycleVM(f))
                                   .ToList();



                return PartialView("_CyclesList", model);


            }
            catch (Exception ex)
            {

                return PartialView("_CyclesList", ex);
            }


        }
        #endregion


        #region activation status

        public JsonResult Deactivate(int CycletId)
        {
            try
            {
                var model = UnitOfWork.CyclesBL.GetByID(CycletId);
                model.IsActive = false;
                UnitOfWork.CyclesBL.Update(model);
                if (UnitOfWork.Complete(LoggedUserId) > 0)
                {
                    return Json(new { Success = true, Message = ApplicationMessages.UpdateSuccess });


                }
                else
                {
                    return Json(new { Success = false, Message = ApplicationMessages.UpdateFailed });

                }
            }
            catch (Exception)
            {

                return Json(new { Success = false, Message = ApplicationMessages.ErrorOccure });

            }

        }

        public JsonResult Activate(int CycletId)
        {
            try
            {
                var model = UnitOfWork.CyclesBL.GetByID(CycletId);
                model.IsActive = true;
                UnitOfWork.CyclesBL.Update(model);
                if (UnitOfWork.Complete(LoggedUserId) > 0)
                {
                    return Json(new { Success = true, Message = ApplicationMessages.UpdateSuccess });


                }
                else
                {
                    return Json(new { Success = false, Message = ApplicationMessages.UpdateFailed });

                }
            }
            catch (Exception)
            {

                return Json(new { Success = false, Message = ApplicationMessages.ErrorOccure });

            }
        }
        #endregion


        #region Cycle Details

        #region DetailsIndexTab
        [HttpGet]
        public IActionResult CycleDetails(int id)
        {
            var cycle = UnitOfWork.CyclesBL.GetCyclewithDep(id);
            if (cycle != null)
            {
                var model = new CycleVM()
                {
                    CycleId = cycle.CycleId,
                    Name = cycle.Name,
                    CycleType = cycle.Type,
                    StartDate = cycle.StartDate,
                    EndDate = cycle.EndDate,
                    ReconciliationDate = cycle.ReconciliationDate,
                    Department = cycle.Department?.Name,
                };
                ViewBag.Title = model.Name;
                return View(model);
            }
            return RedirectToAction("index", "Home");

        }



        [HttpGet]
        [PermissionNotRequired]
        public PartialViewResult _BasicCycleDetailsTab()
        {

            return PartialView("_BasicCycleDetailsTab");
        }

        #endregion

        #region _Product Detalis Tab

        [HttpGet]
        [PermissionNotRequired]
        public IActionResult _CycleProductDetails()
        {
            return View("_CycleProductDetails");
        }

        [PermissionNotRequired]
        public JsonResult GetAllProductsCycleDetails(int cycleId)
        {
            var cycleProducts = UnitOfWork.ProductBL.GetproductInCycle(cycleId);
            var products = cycleProducts.Select(f =>
            {
                string productType = string.Empty;
                if (f.Product.TypeId != null)
                {
                    try
                    {
                        productType = ((ProductType)f.Product.TypeId).ToString();
                    }
                    catch { }
                }
                return new ProductDetalisCycle
                {
                    CycleId = f.Cycle.CycleId,
                    CycleName = f.Cycle.Name,
                    Id = f.ProductId.GetValueOrDefault(),
                    Name = f.Product.Name,
                    Quantity = f.Qunt,
                    TypeId = f.Product.TypeId.GetValueOrDefault(),
                    TypeName = productType,
                };
            }).ToList();
            return Json(products);
        }
        #endregion

        #region Territory Details Tab
        [PermissionNotRequired]
        public PartialViewResult CycleTerritoryDetails()
        {
            return PartialView("CycleTerritoryDetails");
        }
        #endregion
        //[PermissionNotRequired]
        //public PartialViewResult cycleUserDetails()
        //{

        //    return PartialView();
        //}

        #region User Details Tab
        [PermissionNotRequired]
        public PartialViewResult _CycleUserDetails()
        {
            return PartialView();
        }
        

        [PermissionNotRequired]
        public JsonResult GetAllUsersCycleDetails(int? cycleId = null)
        {

            var selectedUsers = UnitOfWork.CycleUserBL.GetUserCycle(c => c.CycleId == cycleId)
                                                      .ToList();

            var model = new CycleDto_Users
            {
                Items = selectedUsers.Select(u => new UserItem
                {
                    Id = u.Id,
                    Name = u.Name,
                    JobTitleId = u.JobTitleId,
                    JobTitleName = u.JobTitleName,
                    DepartmentId = u.DepartmentId,

                }).ToList()
            };
            return Json(model);
        }
        #endregion





        #endregion


        [PermissionNotRequired]
        [HttpPost]
        public JsonResult CycleDetalisTab(_CycleDetalisTab model)
        {
            return Json(ModelState.IsValid);
        }

        #region NewCycle


        [HttpGet]
        public IActionResult CreateCycle()
        {
            ViewBag.Title = "New Cycle";
            return View("NewCycle", new _CycleDetalisTab());
        }

        [HttpGet]
        public IActionResult UpdateCycle(int id)
        {
            ViewBag.Title = $"Update Cycle";
            var cycle = UnitOfWork.CyclesBL.GetByID(id);
            return View("NewCycle", new _CycleDetalisTab(cycle));
        }

        #endregion

        #region LoadCycleStatus

        [HttpGet]
        [PermissionNotRequired]
        public JsonResult LoadCycleStatus()
        {

            var status = UnitOfWork.CyclesBL.CycleStatusList();
            return Json(status);
        }
        #endregion

        #region LoadCycleTypes

        [HttpGet]
        [PermissionNotRequired]
        public JsonResult LoadCycleTypes()
        {

            var Types = UnitOfWork.CyclesBL.CycleTypeList();
            return Json(Types);

        }

        [HttpGet]
        [PermissionNotRequired]
        public JsonResult LoadCycleDepartments()
        {

            List<Department> Result = null;
            if (LoggedIsSystemAdmin)
            {
                Result = UnitOfWork.DepartmentBL
                                               .Find(d => d.IsActive == true
                                               && (d.Product.Count(p => p.IsActive == true && p.InventoryQnty > 0) > 0)
                                               && (d.AppUser.Count(u => u.IsActive == true) > 0))
                                               .ToList();
            }
            else // normal user 
            {
                Result = UnitOfWork.DepartmentBL
                                               .Find(d => d.Id == LoggedUserDepartmentId
                                                 && (d.Product.Count(p => p.IsActive == true && p.InventoryQnty > 0) > 0)
                                               && (d.AppUser.Count(u => u.IsActive == true) > 0))
                                                                                                 .ToList();
            }
            var model = Result?
                               .Select(d => new { d.Id, d.Name })
                               .ToArray();


            return Json(model);
        }
        #endregion

        #region TerritoiesData

        [PermissionNotRequired]
        public JsonResult TerritoiesData(int? cycleId = null)
        {
            try
            {
                var terList = UnitOfWork.TerritoriesBL.InitTerritoies(cycleId);
                var json = JsonConvert.SerializeObject(terList);

                return Json(new { Success = true, data = json });
            }
            catch (Exception)
            {
                return Json(new { Success = false });
            }

        }
        [PermissionNotRequired]
        public JsonResult TerritoiesDataDetails(int? cycleId = null)
        {
            try
            {
                var terList = UnitOfWork.TerritoriesBL.CycleTerritoies(cycleId);
                terList = terList.Select(t => { t.state.selected = false; return t; }).ToList();
                var json = JsonConvert.SerializeObject(terList);

                return Json(new { Success = true, data = json });
            }
            catch (Exception)
            {
                return Json(new { Success = false });
            }

        }
        #endregion

        #region _CycleSearch

        [PermissionNotRequired]
        public PartialViewResult _CycleSearch(CycleVM search)
        {
            var selectedIds = new List<int>();
            if (!string.IsNullOrEmpty(search.SelectedTerritories))
            {
                selectedIds = search.SelectedTerritories
                                   .Split(',', StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToList();
            }



            if (!LoggedIsSystemAdmin)
            {
                search.DepartmentIds.Add(LoggedUserDepartmentId);
            }

            var cycles = UnitOfWork.CyclesBL.CycleSearch(search, selectedIds);
            var model = cycles.Select(f => new CycleVM(f))
                              .ToList();

            return PartialView("_CyclesList", model);
        }

        [PermissionNotRequired]
        public PartialViewResult _CycleTerritoies(int? cycleId = null)
        {
            if (cycleId != null)
            {
                ViewBag.CycleId = cycleId.Value;
            }
            return PartialView();
        }

        [PermissionNotRequired]
        public PartialViewResult _CycleTerritory(int? cycleId = null)
        {

            if (cycleId != null)
            {
                ViewBag.CycleId = cycleId.Value;
            }
            return PartialView();
        }

        [PermissionNotRequired]
        public PartialViewResult CreateCycle_Products()
        {
            return PartialView("_CreateCycle_Products");
        }

        [PermissionNotRequired]
        public JsonResult GetAllProducts(int? cycleId = null, int? department = null)
        {
            var products = UnitOfWork.ProductBL.GetAllActiveProductsWithDepartments(department);

            var selectedProducts = UnitOfWork.CycleProductBL.Find(c => c.CycleId == cycleId);
            var model = new CycleDto_Products
            {
                Items = products.Select(p =>
                {
                    var typeName = "";
                    try
                    {
                        if (p.TypeId.GetValueOrDefault() > 0)
                        {
                            typeName = ((ProductType)p.TypeId.GetValueOrDefault()).ToString();
                        }
                    }
                    catch { }
                    int maxQuantity = 0;
                    try
                    {
                        maxQuantity = Convert.ToInt32(p.InventoryQnty.GetValueOrDefault());
                    }
                    catch
                    { }
                    return new ProductItem
                    {
                        Id = p.ProductId,
                        Name = p.Name,
                        Image = p.Image,
                        TypeId = p.TypeId ?? 0,
                        TypeName = typeName,
                        DepartmentId = p.Department?.Id ?? 0,
                        DepartmentName = p.Department?.Name,
                        Quantity = selectedProducts.FirstOrDefault(cp => cp.ProductId == p.ProductId)?.Qunt ?? 0,
                        MaxQuantity = maxQuantity,
                        Selected = selectedProducts.Any(cp => cp.ProductId == p.ProductId),
                    };
                }).ToList()
            };
            return Json(model);
        }
        #endregion



        [PermissionNotRequired]
        public JsonResult CheckCycleName(int id, string name, int Department)
        {
            var result = UnitOfWork.CyclesBL.Find(f => f.CycleId != id && f.Name.ToLower() == name.ToLower() && f.DepartmentId == Department).FirstOrDefault();
            if (result != null)
            {
                return Json(new { Success = true, Message = "Cycle name is Already Exist" });

            }
            else
            {
                return Json(new { Success = false, Message = "Cycle name is Valid" });
            }
        }

        [PermissionNotRequired]
        public PartialViewResult CreateCycle_Users()
        {
            return PartialView("_CreateCycle_Users");
        }

        [PermissionNotRequired]
        public JsonResult GetAllUsers(int? cycleId = null, int? department = null, string territories = null)
        {
            List<AppUser> users;
            if (!string.IsNullOrEmpty(territories))
            {
                List<int> territoryIds = new List<int>();
                try
                {
                    territoryIds = territories.Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                              .Select(int.Parse)
                                              .ToList();
                    users = UnitOfWork.AppUserBL.GetActiveUsersByTerritoriesAndDepartment(territoryIds, department);
                }
                catch
                {
                    users = new List<AppUser>();
                }
            }
            else
            {
                users = UnitOfWork.AppUserBL.Find(u => department == null || u.DepartmentId == department);
            }

            var selectedUsers = UnitOfWork.CycleUserBL.Find(c => c.CycleId == cycleId)
                                                      .Select(c => c.UserId)
                                                      .ToList();

            var model = new CycleDto_Users
            {
                Items = users.Select(u => new UserItem
                {
                    Id = u.Id,
                    Name = u.FullName,
                    JobTitleId = u.JobTitleId ?? 0,
                    JobTitleName = u.JobTitle?.Name,
                    DepartmentId = u.DepartmentId ?? 0,
                    Selected = selectedUsers.Contains(u.Id),
                }).ToList()
            };
            return Json(model);
        }


        [HttpPost]
        public JsonResult CreateCycle(CycleDto model)
        {
            try
            {
                bool success = true;
                string errorMessage = string.Empty;
                var now = DateTime.Now;
                if (model == null || !ModelState.IsValid)
                {
                    success = false;
                    errorMessage = "Failed to create cycle";
                }
                #region cycle basic details
                DateTime StartDate = DateTime.ParseExact(model.Details.StartDate, "dd/MM/yyyy HH:mm", null);
                // DateTime StartDateTime = StartDate.Date.AddHours(model.Details.start_time); // + new TimeSpan(model.Details.start_time, 0, 0);
                DateTime EndDate = DateTime.ParseExact(model.Details.EndDate, "dd/MM/yyyy HH:mm", null);
                // DateTime EndDateTime = EndDate.Date.AddHours(model.Details.End_time); //+ new TimeSpan(model.Details.End_time, 0, 0);
                DateTime ReconciliationDate = DateTime.ParseExact(model.Details.ReconciliationDate, "dd/MM/yyyy HH:mm", null);
                // DateTime ReconDatetime = ReconciliationDate.Date.AddHours(model.Details.Reconciliation_time);// + new TimeSpan(model.Details.Reconciliation_time, 0, 0);

                var newCycle = new Cycles
                {
                    Name = model.Details.Name,
                    Type = model.Details.Type ?? 0,
                    DepartmentId = model.Details.Department,
                    //  StartDate = DateTime.ParseExact(model.Details.StartDate, "dd/MM/yyyy", null),
                    StartDate = StartDate,
                    //   EndDate = DateTime.ParseExact(model.Details.EndDate, "dd/MM/yyyy", null),
                    EndDate = EndDate,
                    //ReconciliationDate = DateTime.ParseExact(model.Details.ReconciliationDate, "dd/MM/yyyy", null),
                    ReconciliationDate = ReconciliationDate,
                    IsActive = true,
                    Status = (int)POPEnums.CycleStatus.Upcoming, // edit by mo salah
                };
                #endregion

                #region cycle territories
                if (!string.IsNullOrEmpty(model.Territories))
                {
                    var territoryIds = new List<int>();
                    try
                    {
                        territoryIds = model.Territories
                                            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                            .Select(int.Parse)
                                            .ToList();
                    }
                    catch { }
                    if (territoryIds.Count > 0)
                    {
                        var allTerritories = UnitOfWork.TerritoriesBL.GetAllActive();
                        var selectedTerritories = allTerritories.Where(t => territoryIds.Contains(t.TerritoryId)).ToList();
                        var grantedTerritories = new List<Territories>();
                        for (int i = 0; i < selectedTerritories.Count; i++)
                        {
                            var territory = selectedTerritories[i];
                            GetParentTerritories(territory, allTerritories, ref grantedTerritories);
                        }
                        newCycle.CycleTerritory = grantedTerritories.Select(t => new CycleTerritory
                        {
                            TerritoryId = t.TerritoryId
                        }).ToList();
                    }
                }
                else
                {
                    success = false;
                    errorMessage = "No territories selected";
                }
                #endregion

                #region cycle products
                var allProducts = UnitOfWork.ProductBL.GetAllActiveProductsWithDepartments();

                var inventoryLogs = new List<InventoryLog>();
                var transactionDetails = new List<TransactionDetail>();
                var notification = new List<Notifications>();
                if (model.Products.Count > 0)
                {
                    for (int i = 0; i < model.Products.Count; i++)
                    {
                        var item = model.Products[i];
                        var product = allProducts.FirstOrDefault(p => p.ProductId == item.Id);
                        if (product == null)
                        {
                            continue;
                        }
                        var availableQuanity = product.InventoryQnty ?? 0;
                        if (availableQuanity < item.Quantity)
                        {
                            success = false;
                            errorMessage = $"Insufficient quantity for product #{product.ProductId}";
                            break;
                        }
                        product.InventoryQnty -= item.Quantity;
                        UnitOfWork.ProductBL.Update(product);
                        // request is pending for bbx approval 
                        newCycle.CycleProduct.Add(new CycleProduct
                        {
                            ProductId = item.Id,
                            Qunt = 0,   //Qunt = item.Quantity,
                            RemainQunt = 0  //RemainQunt = item.Quantity,
                        });
                        inventoryLogs.Add(new InventoryLog
                        {
                            ProductId = item.Id,
                            OldQnty = availableQuanity,
                            NewQnty = availableQuanity - item.Quantity,
                            Quantity = item.Quantity,
                            TransactionType = (int)TransactionTypes.Delivery,
                            UserId = LoggedUserId,
                            CreatedDate = now,
                            ActionType = (int)InventoryActionType.Decrement,
                        });
                        transactionDetails.Add(new TransactionDetail
                        {
                            ProductId = item.Id,
                            TransAmount = item.Quantity,
                        });
                    }
                }
                else
                {
                    success = false;
                    errorMessage = "No products selected";
                }
                #region Add Notification

                notification.Add(new Notifications
                {

                    CreatedAt = DateTime.Now,
                    Title = NotificationType.Unconfirmed.ToString(),
                    Notificationtype = (int)NotificationType.Unconfirmed,
                    IsSeen = false,
                    ToUserId = model.BBXUser
                });

                #endregion

                var transaction = new Transaction
                {
                    TransType = (int)TransactionTypes.Delivery,
                    Status = (int)TransactionStatus.New_Request,
                    CreatedById = LoggedUserId,
                    CreateDate = now,
                    InventoryLog = inventoryLogs,
                    TransactionDetail = transactionDetails,
                    Notifications = notification,
                    FromUserId = model.BBXUser, // bbx
                    ToUserId = model.HRUser
                };

                newCycle.Transaction.Add(transaction);
                #endregion

                #region cycle users
                if (model.Users.Count > 0)
                {
                    for (int i = 0; i < model.Users.Count; i++)
                    {
                        var item = model.Users[i];
                        newCycle.CycleUser.Add(new CycleUser
                        {
                            UserId = item,
                        });
                    }
                }
                else
                {
                    success = false;
                    errorMessage = "No users selected";
                }

                #endregion

                if (success)
                {

                    UnitOfWork.CyclesBL.Add(newCycle);
                    if (UnitOfWork.Complete(LoggedUserId) > 0)
                    {
                        return Json(new
                        {
                            Ok = true,
                            Message = "Cycle added successfully",
                        });
                    }
                    else
                    {
                        return Json(new
                        {
                            Ok = false,
                            Message = "Failed to add cycle",
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
            catch (Exception e)
            {
                return Json(new
                {
                    Ok = false,
                    Message = "An error occured , Failed to add cycle",
                });
            }
        }

        [HttpPost]
        public JsonResult UpdateCycle(CycleDto model)
        {
            bool success = true;
            string errorMessage = string.Empty;
            var now = DateTime.Now;
            if (model == null || model.Id == 0 || !ModelState.IsValid)
            {
                success = false;
                errorMessage = "Failed to create cycle";
            }
            #region cycle basic details
            DateTime StartDate = DateTime.ParseExact(model.Details.StartDate, "dd/MM/yyyy HH:mm", null);
            //DateTime StartDateTime = StartDate.Date.AddHours(model.Details.start_time); // + new TimeSpan(model.Details.start_time, 0, 0);
            DateTime EndDate = DateTime.ParseExact(model.Details.EndDate, "dd/MM/yyyy HH:mm", null);
            //DateTime EndDateTime = EndDate.Date.AddHours(model.Details.End_time); //+ new TimeSpan(model.Details.End_time, 0, 0);
            DateTime ReconciliationDate = DateTime.ParseExact(model.Details.ReconciliationDate, "dd/MM/yyyy HH:mm", null);
            //DateTime ReconDatetime = ReconciliationDate.Date.AddHours(model.Details.Reconciliation_time);// + new TimeSpan(model.Details.Reconciliation_time, 0, 0);


            var cycle = UnitOfWork.CyclesBL.GetByID(model.Id);
            cycle.Name = model.Details.Name;
            cycle.Type = model.Details.Type ?? 0;
            cycle.DepartmentId = model.Details.Department;
            cycle.StartDate = StartDate;
            cycle.EndDate = EndDate;
            cycle.ReconciliationDate = ReconciliationDate;

            UnitOfWork.CyclesBL.Update(cycle);
            #endregion

            #region cycle territories
            if (!string.IsNullOrEmpty(model.Territories))
            {
                var territoryIds = new List<int>();
                try
                {
                    territoryIds = model.Territories
                                        .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse)
                                        .ToList();
                }
                catch { }
                if (territoryIds.Count > 0)
                {
                    var allTerritories = UnitOfWork.TerritoriesBL.GetAllActive();
                    var oldTerritories = UnitOfWork.TerritoriesBL.GetAllByCycleId(model.Id);
                    var selectedTerritories = allTerritories.Where(t => territoryIds.Contains(t.TerritoryId)).ToList();
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

                    UnitOfWork.CyclesBL.DetachTerritories(model.Id, toRemove);
                    UnitOfWork.CyclesBL.AttachTerritories(model.Id, toAdd);
                }
            }
            else
            {
                success = false;
                errorMessage = "No territories selected";
            }
            #endregion

            #region cycle products (Hashed)
            /*
            var allProducts = UnitOfWork.ProductBL.GetAllActiveProductsWithDepartments();

            var inventoryLogs = new List<InventoryLog>();
            var transactionDetails = new List<TransactionDetail>();
            if (model.Products.Count > 0)
            {
                for (int i = 0; i < model.Products.Count; i++)
                {
                    var item = model.Products[i];
                    var product = allProducts.FirstOrDefault(p => p.ProductId == item.Id);
                    if (product == null)
                    {
                        continue;
                    }
                    var availableQuanity = Convert.ToInt32(product.InventoryQnty ?? 0);
                    if (availableQuanity < item.Quantity)
                    {
                        success = false;
                        errorMessage = $"Insufficient quantity for product #{product.ProductId}";
                        break;
                    }
                    product.InventoryQnty -= item.Quantity;
                    UnitOfWork.ProductBL.Update(product);
                    newCycle.CycleProduct.Add(new CycleProduct
                    {
                        ProductId = item.Id,
                        Qunt = item.Quantity,
                        RemainQunt = item.Quantity,
                    });
                    inventoryLogs.Add(new InventoryLog
                    {
                        ProductId = item.Id,
                        OldQnty = availableQuanity,
                        NewQnty = availableQuanity - item.Quantity,
                        Quantity = item.Quantity,
                        TransactionType = (int)TransactionTypes.Delivery,
                        UserId = LoggedUserId,
                        CreatedDate = now,
                        ActionType = (int)TransactionStatus.NewRequst,
                    });
                    transactionDetails.Add(new TransactionDetail
                    {
                        ProductId = item.Id,
                        TransAmount = item.Quantity,
                    });
                }
            }
            else
            {
                success = false;
                errorMessage = "No products selected";
            }

            var transaction = new Transaction
            {
                TransType = (int)TransactionTypes.Delivery,
                Status = (int)TransactionStatus.NewRequst,
                CreatedById = LoggedUserId,
                CreateDate = now,
                InventoryLog = inventoryLogs,
                TransactionDetail = transactionDetails,
            };

            newCycle.Transaction.Add(transaction);
            */
            #endregion

            #region cycle users
            if (model.Users.Count > 0)
            {
                var oldUsers = UnitOfWork.AppUserBL
                                         .GetAllByCycleId(model.Id)
                                         .Select(u => u.Id)
                                         .ToList();

                var toRemove = oldUsers.Except(model.Users)
                                       .ToList();

                var toAdd = model.Users.Except(oldUsers)
                                       .ToList();

                UnitOfWork.CyclesBL.AttachUsers(model.Id, toAdd);
                UnitOfWork.CyclesBL.DetachUsers(model.Id, toRemove);
            }
            else
            {
                success = false;
                errorMessage = "No users selected";
            }

            #endregion

            if (success)
            {
                if (UnitOfWork.Complete(LoggedUserId) > 0)
                {
                    return Json(new
                    {
                        Ok = true,
                        Message = "Cycle updated successfully",
                    });
                }
                else
                {
                    return Json(new
                    {
                        Ok = false,
                        Message = "Failed to update cycle",
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

        [HttpPost]
        [PermissionNotRequired]
        public JsonResult GetHrUsers([FromBody]List<int> data)
        {
            var hrs = UnitOfWork.AppUserBL.GetHrUsers(data).Select(f => new UserDetailsDto
            {
                Id = f.Id,
                JobTitleName = f.JobTitle.Name,
            });

            return Json(hrs);
        }
    }
}
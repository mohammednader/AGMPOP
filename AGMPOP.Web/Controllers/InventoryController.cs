using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AGMPOP.BL.CoreBL;
using AGMPOP.BL.Models.Domain;
using AGMPOP.BL.Models.ViewModels;
using AGMPOP.Web.Auth;
using AGMPOP.Web.Models;
using AGMPOP.Web.Models.Inventory;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;

namespace AGMPOP.Web.Controllers
{
    [AppAuthorize]
    public class InventoryController : BaseController
    {
        private readonly IUnitOfWork UnitOfWork;
        public InventoryController(IUnitOfWork _unitOfWork)
        {
            UnitOfWork = _unitOfWork;
        }
        public IActionResult Index()
        {

            return View();
        }


        public PartialViewResult Search(ProductDTO obj, bool ShowUpdateBtns = true)
        {
            //Search in product
            try
            {
                if (obj != null)
                {

                    List<Product> Result = null;
                    obj.IsInventory = true;
                    if (LoggedIsSystemAdmin)
                    {
                        Result = UnitOfWork.ProductBL.FilterProducts(obj).ToList();
                    }
                    else // normal user 
                    {
                        obj.IsInventory = true;
                        obj.UserDepartmentId = LoggedUserDepartmentId;
                        Result = UnitOfWork.ProductBL.FilterProducts(obj);

                    }
                    var model = Result?.Select(p => new ProductDTO
                    {

                        Code = p.Code,
                        CreatedBy = p.CreatedBy,
                        Image = p.Image,
                        Department = p.Department,
                        DepartmentName = p.Department.Name,
                        Name = p.Name,
                        //    TypeId = p.TypeId ?? 0,
                        CreatedDate = p.CreatedDate,
                        IsActive = p.IsActive,
                        typeId = p.TypeId,
                        // Types= ProductTypeList
                        ProductName = p.Name,
                        InventoryQnty = p.InventoryQnty,
                        ProductId = p.ProductId,
                        DepartmentID = p.DepartmentId ?? 0,
                        ShowUpdateBtns = ShowUpdateBtns

                    }).OrderByDescending(p => p.ProductId).ToList();

                    return PartialView("_ProductTransaction", model);

                }
                return PartialView("_ProductTransaction", null);
            }
            catch (Exception)
            {
                return PartialView("_ProductTransaction", null);

            }


        }

        public ViewResult TransactionProductDetails(int id)
        {
            //var productTrans = UnitOfWork.InventoryLogBL.GetProductsWithTransaction(id);
            var productTrans = UnitOfWork.InventoryLogBL.GetIventoryLogTrans(id);

            var UserIds = productTrans?.Select(t => t.UserId).ToList();

            var AllUsers = UnitOfWork.AppUserBL.GetAllWithSystemAdmin(u => UserIds.Contains(u.Id));
            var model = productTrans.Select(f => new InventoryTransaction(f)
            {
                createdBy = AllUsers
                                    .FirstOrDefault(u => u.Id == f.UserId)
                                    ?.FullName
            });
            return View(model);
        }


        public JsonResult EditQuantity(string Id, string Qunt)
        {
            // auth will be checked here 
            try
            {
                var LoggedUser = Convert.ToInt32(((ClaimsIdentity)User.Identity)?.FindFirst("UserId").Value ?? "0");
                if (!string.IsNullOrEmpty(Id) && !string.IsNullOrEmpty(Qunt))
                {
                    int id = 0;
                    decimal Quantity = decimal.Parse(Qunt);
                    int.TryParse(Id, out id);
                    var product = UnitOfWork.InventoryLogBL.GetProductsWithTransaction(id).FirstOrDefault();
                    if (product != null)
                    {
                        //int ProductQuantity = int.Parse(Qunt);
                        if (product.InventoryQnty.Value < Quantity)
                        {
                            product.InventoryLog.Add(
                                                      new InventoryLog
                                                      {
                                                          ProductId = product.ProductId,
                                                          Quantity = (Quantity - product.InventoryQnty.Value),
                                                          UserId = LoggedUser,
                                                          CreatedDate = DateTime.Now,
                                                          ActionType = (int)POPEnums.InventoryActionType.Increment,
                                                          OldQnty = product.InventoryQnty.GetValueOrDefault(),
                                                          NewQnty = Quantity
                                                      });

                            product.InventoryQnty = Quantity;
                            UnitOfWork.ProductBL.Update(product);

                            if (UnitOfWork.Complete(LoggedUserId) > 0)
                            {
                                // success 
                                return Json(new { Success = true, Message = ApplicationMessages.UpdateSuccess });
                            }
                        }
                        else
                        {

                            return Json(new { Success = false, Message = "Please ,Enter Quantity  greater than old one ! " });

                        }
                        return Json(new { Success = false, Message = ApplicationMessages.UpdateFailed });
                    }



                    else
                    {
                        return Json(new { Success = false, Message = ApplicationMessages.UpdateFailed });
                    }
                }
                else return Json(new { Success = false, Message = ApplicationMessages.IncompleteData });
            }
            catch (Exception e)
            {
                return Json(new { Success = false, Message = ApplicationMessages.ErrorOccure, Error = e.Message });
            }
        }


        [HttpGet]
        public FileResult ExportInventory(ProductDTO obj)
        {
            using (var stream = new MemoryStream())
                try
                {
                    var ProductList = UnitOfWork.ProductBL.FilterProducts(obj).Select(p => new ProductDTO
                    {
                        DepartmentName = p.Department.Name,
                        ProductName = p.Name,
                        InventoryQnty = p.InventoryQnty,
                        ProductId = p.ProductId,
                    }).ToArray();


                    var LstToExport = ProductList
                                        .Select(p => new InventoryExport(p))
                                        .ToArray();


                    var ProdDT = Helper.GenerateDataTable(LstToExport);

                    using (var wb = new XLWorkbook())
                    {
                        wb.Worksheets.Add(ProdDT, "Inventory");

                        wb.SaveAs(stream);
                        return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Inventory.xlsx");

                    }
                }
                catch (Exception e)
                {
                    return File(stream.ToArray(), e.ToString());

                }



        }

        [HttpGet]
        public FileResult ExportTransactionInventory(string id)
        {
            var ProductId = int.Parse(id);
            var stream = new MemoryStream();
            try
            {
                var productTrans = UnitOfWork.InventoryLogBL.GetIventoryLogTrans(ProductId);
                var UserIds = productTrans?.Select(t => t.UserId).ToList();

                var AllUsers = UnitOfWork.AppUserBL.Find(u => UserIds.Contains(u.Id)).ToList();
                var listToExport = productTrans.Select(p => new InventoryTransactionExport
                {
                    ProductName = p.Product.Name,
                    CycleName = p.Transaction?.Cycle.Name,
                    Quantity = p.Quantity.GetValueOrDefault(),
                    OldQuantity = p.OldQnty.GetValueOrDefault(),
                    NewQuantity = p.NewQnty.GetValueOrDefault(),
                    CreatedDate = p.CreatedDate.HasValue ? p.CreatedDate.ToString() : "",
                    ActionType = (p.ActionType.HasValue && p.ActionType == (int)POPEnums.InventoryActionType.Increment) ? "Increment" : "Decrement",
                    createdBy = AllUsers
                                        .Where(u => u.Id == p.UserId)
                                        .Select(u => u.FullName)
                                        .FirstOrDefault()

                });

                var ProdDT = Helper.GenerateDataTable(listToExport.ToArray());

                using (var wb = new XLWorkbook())
                {
                    wb.Worksheets.Add(ProdDT, "InventoryLog");

                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "InventoryLog.xlsx");

                }
            }
            catch (Exception e)
            {
                return File(stream.ToArray(), e.ToString());

            }
        }
    }
}
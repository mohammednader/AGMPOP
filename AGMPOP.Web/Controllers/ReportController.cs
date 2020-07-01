using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AGMPOP.BL.CoreBL;
using AGMPOP.BL.Models.Domain;
using AGMPOP.BL.Models.ViewModels;
using AGMPOP.Web.Models;
using AGMPOP.Web.Models.Cycle;
using ClosedXML.Excel;

using AGMPOP.Web.Models.Transaction;

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using AGMPOP.Web.Auth;
using AGMPOP.Web.Models.Inventory;
using static AGMPOP.BL.Models.ViewModels.POPEnums;
using Newtonsoft.Json.Linq;
using AGMPOP.Web.Models.Audit;

namespace AGMPOP.Web.Controllers
{
    [AppAuthorize]
    public class ReportController : BaseController
    {
        private readonly IUnitOfWork UnitOfWork;
        public ReportController(IUnitOfWork _UnitOfWork)
        {
            UnitOfWork = _UnitOfWork;
        }

        #region transactionReport
        public IActionResult TransactionIndex(string name = "", int? userId = 0, int? cycleId = 0, string productName = "")
        {
            ViewBag.userId = userId.Value;
            return View();
        }

        [PermissionNotRequired]
        public JsonResult GetAllTypes()
        {

            var result = new List<object>();
            foreach (var item in Enum.GetValues(typeof(POPEnums.TransactionTypes)))
            {
                result.Add(new { type = item.ToString(), id = (int)item });
            }
            return Json(result);
        }

        [PermissionNotRequired]
        public JsonResult GetAllStatus()
        {
            var result = new List<object>();
            foreach (var item in Enum.GetValues(typeof(POPEnums.TransactionStatus)).Cast<POPEnums.TransactionStatus>())
            {
                result.Add(new { status = item.ToString().Replace("_", " "), id = (int)item });
            }
            return Json(result);
        }


        public List<TransactionCycle> SeachInTransaction(TransactionCycle form)
        {
            List<Transaction> data = null;
            if (LoggedIsSystemAdmin)
            {
                data = UnitOfWork.TransactionBL.GetTransactionCycleDetails(form).ToList();
            }
            else // normal user 
            {
                data = UnitOfWork.TransactionBL.GetTransactionCycleDetails(form).
                                               Where(d => d.Cycle.DepartmentId == LoggedUserDepartmentId)
                                               .ToList();
            }
            var UserIds = data?.Select(t => t.CreatedById).ToList();

            var AllUsers = UnitOfWork.AppUserBL.GetAllWithSystemAdmin(u => UserIds.Contains(u.Id)).ToList();
            var SelectedData = data?
                                 .Select(c => new TransactionCycle
                                 {
                                     CycleName = c.Cycle?.Name,
                                     FromUserName = c.FromUser?.FullName,
                                     Date = c.CreateDate?.ToString(),
                                     Status = c.Status.GetValueOrDefault(),
                                     Type = c.TransType.GetValueOrDefault(),
                                     ToUserName = c.ToUser?.FullName,
                                     TotalItem = c.TransactionDetail?.ToList(),
                                     TransId = c.TransactionId,
                                     //  CreatedBy = c.CreatedById.ToString()
                                     CreatedBy = AllUsers
                                                       .Where(u => u.Id == c.CreatedById)
                                                       .Select(u => u.FullName)
                                                       .FirstOrDefault()
                                 }).OrderByDescending(t => t.Date).ToList();
            return SelectedData;
        }

        [PermissionNotRequired]
        public PartialViewResult Search(TransactionCycle form)
        {

            try
            {
                if (form != null)
                {
                    if (form.CycleId != 0)
                    {
                        //  form.CycleId = form. cycleId;
                        ViewBag.showdata = 1;
                    }
                    else
                    {
                        ViewBag.showdata = 0;
                    }

                    // call search function

                    var data = SeachInTransaction(form);

                    return PartialView("_TransactionReport", data);
                }
                return PartialView("_TransactionReport", null);
            }
            catch (Exception ex)
            {
                return PartialView("_TransactionReport", null);
            }
        }

        [HttpGet]
        public FileResult ExportTransaction(TransactionCycle form)
        {
            var stream = new MemoryStream();
            try
            {
                // call search function
                var data = SeachInTransaction(form);
                var sheet = new List<TransactionExport>();

                foreach (var item in data)
                {
                    sheet.Add(new TransactionExport() {
                        CycleName = item.CycleName??string.Empty, 
                        FromUserName = item.FromUserName??string.Empty,
                        ToUser = item.ToUserName??string.Empty,
                        Date = item.Date, 
                        Status = Enum.GetName(typeof(POPEnums.TransactionStatus),item.Status).ToString().Replace("_", " "),
                        Type = Enum.GetName(typeof(POPEnums.TransactionTypes), item.Type),
                        TotalItem = item.TotalItem.Count() 
                    });

                }
                var ProdDT = Helper.GenerateDataTable(sheet.ToArray());

                using (var wb = new XLWorkbook())
                {
                    wb.Worksheets.Add(ProdDT, "Transaction");

                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Transaction.xlsx");

                }
            }
            catch (Exception e)
            {
                return File(stream.ToArray(), e.ToString());

            }


        }
        #endregion

        #region CycleIndex

        public IActionResult CycleIndex()
        {
            var terList = UnitOfWork.TerritoriesBL.InitTerritoies();
            var json = JsonConvert.SerializeObject(terList);

            ViewBag.TreeData = json;
            return View();
        }

        #endregion

        #region CyclesList
        [PermissionNotRequired]
        public PartialViewResult _CycleReport()
        {
            try
            {

                var model = UnitOfWork.CyclesBL.GetCycleWithProduct()
                                               .Select(f => new CycleVM(f))
                                               .ToList();


                return PartialView("_CycleReport", model);


            }
            catch (Exception ex)
            {

                return PartialView("_CycleReport", ex);
            }


        }
        #endregion

        #region StockTotal
        [PermissionNotRequired]
        public JsonResult StockTotal(int cycleid)
        {
            if (cycleid != 0)
            {
                var model = UnitOfWork.CycleProductBL.GetCycleProduct(c => c.CycleId == cycleid);
                return Json(model);
            }

            return Json(null);
        }
        #endregion

       

        #region ExportCycleReport
        public FileResult ExportCycelReport(CycleVM form)
        {
            using (var stream = new MemoryStream())
                try
                {
                    var ListCycle = FilterCycle(form);
                    var SheetCycle = ListCycle.Select(c => new CycleExport(c)).ToArray();

                    var CycelReport = Helper.GenerateDataTable(SheetCycle);

                    using (var wb = new XLWorkbook())
                    {
                        wb.Worksheets.Add(CycelReport, "CyclesReport");

                        wb.SaveAs(stream);
                        return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "CyclesReport.xlsx");

                    }
                }
                catch (Exception e) { return null; }
        }
        #endregion

        #region filterCyclesReport

        [PermissionNotRequired]
        public PartialViewResult filterCyclesReport(CycleVM search)
        {
            var model = FilterCycle(search);
            return PartialView("_CycleReport", model);
        }
        [PermissionNotRequired]
        public IList<CycleVM> FilterCycle(CycleVM search) 
        {
            try
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
                return model;
            }
            catch (Exception e)
            {
                return null;

            }

        }

        #endregion

        #region StockReportIndex

        public IActionResult StockReportIndex()
        {
            ViewBag.show = 1;
            return View();
        }
        #endregion

        #region SearchStock

        [PermissionNotRequired]
        public PartialViewResult SearchStock(ProductDTO obj, bool ShowUpdateBtns = false)
        {
            //Search in product
            try
            {
                if (obj != null)
                {
                    List<Product> Result = null;
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
        #endregion
        #region ExportInventoryReport
        [PermissionNotRequired]
        public FileResult ExportInventoryReport(ProductDTO obj)
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

        #endregion
        #region TransactionProductDetails

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
            return View("../Inventory/TransactionProductDetails", model);
        }
        #endregion

        #region Audit
        [PermissionNotRequired]
        public ActionResult Audit()
        {
            return View();
        }

        [PermissionNotRequired]
        public PartialViewResult _AuditReport(AuditSearchVM search)
        {
            List<AuditSearchVM> Data = new List<AuditSearchVM>();
            var Result = UnitOfWork.AuditBL.AuditSearch(search)
                                           .Select(au => new AuditSearchVM
                                           {
                                               UserName = au.User?.FullName,
                                               AuditId = au.Id,
                                               Date = au.Date,
                                               ActionName = Enum.GetName(typeof(AuditActionType), au.ActionTypeId).ToString(),
                                               TableName = au.TableName,
                                               OldData = au.OldData,
                                               NewData = au.NewData
                                           }).ToList();
                                            
            return PartialView(Result);
        }
        #endregion

        #region AuditExport
        [PermissionNotRequired]
        public FileResult ExportAuditReport(AuditSearchVM search)
        {
            using (var stream = new MemoryStream())
                try
                {
                    var Result = UnitOfWork.AuditBL.AuditSearch(search);
                    var SheetAudit = Result.Select(c => new AuditExport(c)).ToArray();

                    var CycelReport = Helper.GenerateDataTable(SheetAudit);

                    using (var wb = new XLWorkbook())
                    {
                        wb.Worksheets.Add(CycelReport, "AuditReport");

                        wb.SaveAs(stream);
                        return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "AuditReport.xlsx");

                    }
                }
                catch (Exception e) { return null; }
        }
        #endregion



    }
}
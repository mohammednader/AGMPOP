using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AGMPOP.BL.CoreBL;
using AGMPOP.BL.Models.Domain;
using AGMPOP.BL.Models.ViewModels;
using AGMPOP.Web.Auth;
using AGMPOP.Web.Models;
using AGMPOP.Web.Models.Territory;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AGMPOP.Web.Controllers
{
    [AppAuthorize]
    public class TerritoryController : BaseController
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly IHostingEnvironment env;

        public TerritoryController(IUnitOfWork _unitOfWork, IHostingEnvironment _env)
        {
            UnitOfWork = _unitOfWork;
            env = _env;
        }


        public IActionResult Index()
        {
            return View();
        }

        #region PartialTerritoies


        public PartialViewResult PartialTerritories()
        {
            try
            {

                var terList = UnitOfWork.TerritoriesBL.InitTerritoies();
                var json = JsonConvert.SerializeObject(terList);

                ViewBag.TreeData = json;

                return PartialView("_PartialIndex");
            }
            catch (Exception)
            {
                return PartialView("_PartialIndex", null);

            }
        }
        #endregion


        #region Create or rename 

        [HttpPost]
        public JsonResult Create(string str)
        {
            try
            {
                var myJsonString = str;
                var jo = JObject.Parse(myJsonString);
                var id = jo["id"].ToString();
                var text = jo["text"].ToString();
                var parent = jo["parent"].ToString();


                int _id = 0;
                int.TryParse(id, out _id);
                int _parent = 0;
                int.TryParse(parent, out _parent);
                 if (_parent != 0)
                {
                    var terrWithSameName = UnitOfWork.TerritoriesBL.GetAll().Where(f => f.ParentId == _parent && f.Name.ToLower() == text.ToLower() && f.Inactive == false).ToList();
                    if (terrWithSameName.Count == 0)
                    {
                        UnitOfWork.TerritoriesBL.Save(new Territories() { TerritoryId = _id, Name = text, ParentId = _parent });
                    }
                    else
                    {
                        return Json(new { Success = false, Message = "This name is exist" });
                    }

                }
                else
                {
                    var terrWithSameName = UnitOfWork.TerritoriesBL.GetAll().Where(f => f.TerritoryId == _id && f.Name.ToLower() == text.ToLower() && f.Inactive == false).ToList();
                    if (terrWithSameName.Count == 0)

                    {
                        UnitOfWork.TerritoriesBL.Save(new Territories() { TerritoryId = _id, Name = text, ParentId = null });
                    }
                    else
                    {
                        return Json(new { Success = false, Message = "This name is exist" });

                    }
                }

                if (UnitOfWork.Complete(LoggedUserId) > 0)
                {
                    // success
                    return Json(new { Success = true, nodeId = _id, Message = ApplicationMessages.SaveSuccess });
                }
                else
                {
                    return Json(new { Success = false, Message = "Failed" });
                }
            }
            catch (Exception e)
            {
                // error
                return Json(new { Success = false, Message = ApplicationMessages.ErrorOccure, Error = e.Message });
            }

        }

        [HttpPost]
        public JsonResult Edit(string str)
        {
            try
            {

                var myJsonString = str;
                var jo = JObject.Parse(myJsonString);
                var id = jo["id"].ToString();
                var text = jo["text"].ToString();
                var parent = jo["parent"].ToString();


                int _id = 0;
                int.TryParse(id, out _id);
                int _parent = 0;
                int.TryParse(parent, out _parent);
                if (_parent != 0)
                {
                    var terrWithSameName = UnitOfWork.TerritoriesBL.GetAll().Where(f => f.ParentId == _parent && f.Name.ToLower() == text.ToLower() && f.Inactive == false).ToList();
                    if (terrWithSameName.Count == 0)
                    {
                        UnitOfWork.TerritoriesBL.Save(new Territories() { Name = text, ParentId = _parent });

                    }
                    else
                    {
                        return Json(new { Success = false, Message = "This name is exist" });
                    }
                }

                else
                {
                    var terrWithSameName = UnitOfWork.TerritoriesBL.GetAll().Where(f => f.TerritoryId == _id && f.Name.ToLower() == text.ToLower() && f.Inactive == false).ToList();
                    if (terrWithSameName.Count == 0)

                    {
                        UnitOfWork.TerritoriesBL.Save(new Territories() { Name = text, ParentId = null });
                    }
                    else
                    {
                        return Json(new { Success = false, Message = "This name is exist" });

                    }
                }

                if (UnitOfWork.Complete(LoggedUserId) > 0)
                {
                    // success
                    return Json(new { Success = true, nodeId = _id, Message = ApplicationMessages.SaveSuccess });
                }
                else
                {
                    return Json(new { Success = false, Message = "Failed" });
                }
            }
            catch (Exception e)
            {
                // error
                return Json(new { Success = false, Message = ApplicationMessages.ErrorOccure, Error = e.Message });
            }
        }

        #endregion

        #region Delete

        [HttpGet]
        public JsonResult Delete(int id)
        {

            try
            {
                //*** get all user which have to Permission this Territory  (id) ***//
                var UserAssignedtoTerr = UnitOfWork.TerritoriesBL.userTerritory(id);

                //*** get all child from this parent (id) ***//
                var ParentIds = UnitOfWork.TerritoriesBL.Find(f => f.ParentId == id && f.Inactive == false).ToList();
                var cyclesInTerr = UnitOfWork.TerritoriesBL.GetCycleInTerr(id);

                string Msg = "";
                if (ParentIds.Count > 0)
                {
                    Msg = "Delete childs first!";
                }

                if (UserAssignedtoTerr.Count > 0)
                {
                    Msg = "There are users assigned to this territories";
                }
                if (cyclesInTerr.Count > 0)
                {
                    Msg = "There are cycles assigned to this territories";
                }

                if (ParentIds.Count == 0 && UserAssignedtoTerr.Count == 0 && cyclesInTerr.Count == 0)
                // if (ParentIds.Count == 0)

                {
                    var item = UnitOfWork.TerritoriesBL.GetByID(id);
                    item.Inactive = true;
                    UnitOfWork.TerritoriesBL.Update(item);
                }
                if (UnitOfWork.Complete(LoggedUserId) > 0)
                {
                    // success
                    return Json(new { Success = true, Message = ApplicationMessages.DeleteSuccess });
                }
                else
                {
                    return Json(new { Success = false, Message = ApplicationMessages.DeleteFailed });
                }
            }
            catch (Exception e)
            {
                // error
                return Json(new { Success = false, Message = ApplicationMessages.ErrorOccure, Error = e.Message });
            }

        }


        #endregion

        #region ExportTerritories

        [HttpGet]
        public FileResult ExportTerritories()
        {
            var stream = new MemoryStream();
            try
            {
                var TerritoryLst = UnitOfWork.TerritoriesBL.GetAllActive().ToList();
                var sheet = new List<TerritoryExport>();

                foreach (var item in TerritoryLst)
                {
                    if (item.Parent != null)
                        sheet.Add(new TerritoryExport() { SubTerritory = item.Name, Territory = item.Parent.Name });
                    else
                        sheet.Add(new TerritoryExport() { SubTerritory = item.Name });
                }
                var TerrDT = Helper.GenerateDataTable(sheet.ToArray());

                using (var wb = new XLWorkbook())
                {
                    wb.Worksheets.Add(TerrDT, "TerritoriestList");

                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "TerritoriestList.xlsx");

                }
            }
            catch (Exception e)
            {
                return File(stream.ToArray(), e.ToString());

            }



        }
        #endregion

        public ActionResult ImportPage()
        {
            return View();
        }

        [HttpPost]
        [PermissionNotRequired]
        public JsonResult ImportTerr(IFormFile fileExcel, string testname)
        {
            try
            {

                if (fileExcel.Length == 0)
                {
                    return Json(new { Ok = false, Message = "File is empty" });
                }
                var fileName = Path.GetFileName(fileExcel.FileName);
                string ext = Path.GetExtension(fileExcel.FileName);

                string NewFileName = "Terr_" + DateTime.Now.ToShortDateString().Replace("/", "-") + "-" + DateTime.Now.ToShortTimeString().Replace(":", "-").Replace(" ", "-") + ext;
                fileName = NewFileName;
                var webRoot = env.WebRootPath;

                string path = System.IO.Path.Combine(webRoot, "Uploads/Terr");
                Directory.CreateDirectory(path);

                string Fullpath = Path.Combine(path, fileName);

                using (XLWorkbook wb = new XLWorkbook(fileExcel.OpenReadStream()))
                {
                    IXLWorksheet sheet;
                   
                    wb.SaveAs(Fullpath);
                    wb.TryGetWorksheet("Sheet1", out sheet);
 
 
                    if (sheet != null)
                    {
                        // get last row
                        string lastrow = sheet.LastRowUsed().RangeAddress.FirstAddress.ToString();
                        lastrow = lastrow.Remove(0, 1);
                        var rowCount = int.Parse(lastrow);
                        // 2 beacuse header
                        var rowRange = sheet.Rows(2, rowCount).ToList();


                        var territories = new List<TerritoryExport>();
                        var rowsCount = rowRange.Count();

                        try
                        {

                            for (int i = 0; i < rowsCount; i++)
                            {
                                var cols = rowRange.ElementAt(i).Cells().ToList();
                                if (!string.IsNullOrEmpty(cols.ElementAt(0).Value.ToString()))
                                {

                                    territories.Add(new TerritoryExport
                                    {
                                        Territory = (string)cols.ElementAt(0).Value,
                                        SubTerritory = (string)cols.ElementAt(1).Value,
                                    });
                                }
                            }
                            for (int i = 0; i < territories.Count; i++)
                            {
                                var _terr = territories[i];
                                int _parentId = UnitOfWork.TerritoriesBL
                                    .Find(f => f.Name.ToLower().Trim() == _terr.SubTerritory.ToLower().Trim() && f.Inactive == false)
                                    .Select(f => f.TerritoryId)
                                    .FirstOrDefault();
                                if (_parentId != 0)
                                {
                                    var NewTerr = new Territories()
                                    {
                                        Name = _terr.Territory,
                                        ParentId = _parentId,
                                        Inactive = false,
                                    };
                                    UnitOfWork.TerritoriesBL.Add(NewTerr);
                                    UnitOfWork.Complete(LoggedUserId);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            return Json(new
                            {
                                success = false,
                                Message = "Invalid file structure",
                            });
                        }
                        if (territories.Count == 0)
                        {
                            return Json(new { success = false, Message = "File is empty" });
                        }
                    }

                    else
                    {
                        return Json(new { success = false, Message = "Something went wrong , please try again later" });

                    }
                }
 
            }
 
            catch (Exception e)
            {
                return Json(new { success = false, Message = "Something went wrong , please try again later" });
            }
            return Json(new { success = true, Message = "Territories Uploaded" });
        }

 
    }

}

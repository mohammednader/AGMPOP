using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using AGMPOP.BL.CoreBL;
using AGMPOP.BL.Models.Domain;
using static System.Net.Mime.MediaTypeNames;
using System.Linq.Expressions;
using AGMPOP.BL.Models.ViewModels;
using System.Security.Claims;
using AGMPOP.Web.Models;
using Newtonsoft.Json;
using ClosedXML.Excel;
using AGMPOP.Web.Models.Product;
using AGMPOP.Web.Auth;
using ICSharpCode.SharpZipLib.Zip;

namespace AGMPOP.Web.Controllers
{
    [AppAuthorize]
    public class ProductController : BaseController
    {

        private readonly IUnitOfWork UnitOfWork;
        private readonly IHostingEnvironment _env;
        public ProductController(IUnitOfWork _unitOfWork, IHostingEnvironment env)
        {
            UnitOfWork = _unitOfWork;
            _env = env;

        }



        #region Index

        public IActionResult Index()
        {
            return View();
        }

        // deprecated (to be removed)
        public PartialViewResult PartialIndex()
        {
            try
            {
                var model = UnitOfWork.ProductBL.GetAllProductList()
                                                .Select(p => new ProductDTO
                                                {

                                                    Code = p.Code,
                                                    CreatedBy = p.CreatedBy,
                                                    Image = p.Image,
                                                    //  Department=p.Department,
                                                    DepartmentName = p.Department.Name,
                                                    Name = p.Name,
                                                    //  TypeId = p.TypeId ?? 0,
                                                    CreatedDate = p.CreatedDate,
                                                    IsActive = p.IsActive,
                                                    // typeId = p.TypeId,
                                                    // Types= ProductTypeList
                                                    ProductName = p.Name,
                                                    InventoryQnty = p.InventoryQnty,
                                                    ProductId = p.ProductId
                                                }).OrderByDescending(p => p.ProductId).ToList();




                return PartialView("_PartialIndex", model);
            }
            catch (Exception)
            {
                return PartialView("_PartialIndex", null);

            }
        }
        #endregion

        #region  Create New product

        [HttpGet]
        public PartialViewResult Create()
        {
            //ViewBag.Department = UnitOfWork.DepartmentBL.GetAll().ToList();
            //ViewBag.TypeId = new SelectList(UnitOfWork.ProductBL.ProductTypeList(), "TypeId", "Name");
            return base.PartialView("_CreateProduct", new ProductVM());
        }


        [HttpPost]
        public JsonResult Create(Models.ProductVM product, IFormFile file)
        {
            if (!ModelState.IsValid)
            {
                return Json(null);
            }
            try
            {
                if (UnitOfWork.ProductBL.CheckExist(p =>
                                               (p.Code == product.Code && p.DepartmentId == product.DepartmentID) ||
                                               (p.Name == product.Name && p.DepartmentId == product.DepartmentID)))

                {
                    return Json(new { Success = false, Message = "Code is exist" });
                }

                if (file != null)
                {
                    var imgPath = @"\Uploads\Product\";
                    var uploadpath = _env.WebRootPath + imgPath;
                    if (!Directory.Exists(uploadpath))
                    {
                        Directory.CreateDirectory(uploadpath);
                    }
                    // create file Name
                    var uniqueName = Guid.NewGuid().ToString();
                    var ext = Path.GetExtension(file.FileName);
                    string imageName = uniqueName + ext;
                    var filepath = Path.Combine(uploadpath, imageName);

                    var model = new Product()
                    {
                        Name = product.Name,
                        Code = product.Code,
                        CreatedBy = LoggedUserId,
                        CreatedDate = DateTime.Now,
                        DepartmentId = product.DepartmentID,
                        Image = Path.Combine(imgPath, imageName),
                        InventoryQnty = product.InventoryQnty,
                        //  TypeId = product.TypeId,
                        IsActive = true,
                    };
                    UnitOfWork.ProductBL.Add(model);

                    try
                    {
                        using (var filestream = new FileStream(filepath, FileMode.Create))
                        {
                            file.CopyTo(filestream);
                        }

                        // another way to save file yasser 
                        //using (var ms = new MemoryStream())
                        //{
                        //    file.CopyTo(ms);
                        //    var fileBytes = ms.ToArray();                            
                        //    // act on the Base64 data
                        //    System.IO.File.WriteAllBytes(filepath, fileBytes);
                        //}

                    }
                    catch (Exception e)
                    {
                        return Json(new { Success = false, Message = "sorry , can't save product image" });
                    }


                    if (UnitOfWork.Complete(LoggedUserId) > 0)
                    {
                        // success
                        return Json(new { Success = true, Message = ApplicationMessages.SaveSuccess });
                    }
                    else
                    {
                        return Json(new { Success = false, Message = ApplicationMessages.SaveFailed });
                    }
                }

                else return Json(new { Success = false, Message = "Incomplete data" });
            }
            catch (Exception e)
            {
                return Json(new { Success = false, Message = "Exception", Error = e.Message });
                // error
            }


        }


        #endregion

        #region Details -- Product Details

        public JsonResult Details(int id)
        {

            try
            {
                var product = UnitOfWork.ProductBL.GetProductWithDepartmentByid(id);

                var obj = new
                {
                    name = product.Name,
                    code = product.Code,
                    createdDate = product.StringCreatedDate,
                    Qunt = product.InventoryQnty,
                    isActive = product.IsActive,
                    department = product.DepartmentName,
                    // type = product.TypeId,
                    image = product.Image
                };

                if (product != null)
                {
                    return Json(new { success = true, message = "data success", data = obj });
                }
                else
                {
                    return Json(new { message = " in complete data !!" });
                }

            }

            catch (Exception e)
            {
                return Json(e);
            }

        }

        #endregion

        #region ProductSearch --Partial View

        public List<ProductDTO> SearchFun(ProductDTO obj)
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
                    //  TypeId = p.TypeId ?? 0,
                    CreatedDate = p.CreatedDate,
                    IsActive = p.IsActive,
                    //   typeId = p.TypeId,
                    // Types= ProductTypeList
                    ProductName = p.Name,
                    InventoryQnty = p.InventoryQnty,
                    ProductId = p.ProductId,
                    DepartmentID = p.DepartmentId ?? 0
                }).OrderByDescending(p => p.ProductId).ToList();
                return model;
            }
            else
            {
                return null;
            }
        }
        public PartialViewResult Search(ProductDTO obj)
        {
            try
            {
                var Model = SearchFun(obj);
                return PartialView("_PartialIndex", Model);
            }
            catch (Exception)
            {
                return PartialView("_PartialIndex", null);

            }
        }
        #endregion

        #region Edit

        [PermissionNotRequired]
        public PartialViewResult EditProduct(int Id)
        {

            var product = UnitOfWork.ProductBL.GetByID(Id);
            var model = new ProductVM
            {
                ProductId = product.ProductId,
                Name = product.Name,
                //TypeId = product.TypeId.GetValueOrDefault(),
                Code = product.Code,
                CreatedBy = product.CreatedBy,
                CreatedDate = product.CreatedDate,
                Image = product.Image,
                InventoryQnty = product.InventoryQnty,
                DepartmentID = product.DepartmentId ?? 0,
                //DepartmentName = product.Department.Name

            };

            if (UnitOfWork.ProductBL.CheckExist(p => p.Code == model.Code && p.DepartmentId == model.DepartmentID))
            {
                ViewBag.DepartmentReadOnly = true;
            }
            else
            {
                ViewBag.DepartmentReadOnly = false;
            }
            return PartialView("_EditProduct", model);
        }


        [HttpPost]
        public ActionResult Edit(ProductVM product, IFormFile file)
        {
            if (!ModelState.IsValid)
            {
                return Json(null);
            }
            try
            {
                if (UnitOfWork.ProductBL.CheckExist(p => (p.ProductId != product.ProductId) &&
                                            (p.Code == product.Code && p.DepartmentId == product.DepartmentID) ||
                                            (p.Name == product.Name && p.DepartmentId == product.DepartmentID)))
                {
                    return Json(new { Success = false, Message = "Code is exist" });
                }

                var model = UnitOfWork.ProductBL.GetByID(product.ProductId);

                model.Name = product.Name;
                model.Code = product.Code;
                model.DepartmentId = product.DepartmentID;
                model.InventoryQnty = product.InventoryQnty;
                // model.TypeId = product.TypeId;
                model.Modified = DateTime.Now;


                if (file != null)
                {
                    var imgPath = @"\Uploads\Product\";
                    var uploadpath = _env.WebRootPath + imgPath;
                    if (!Directory.Exists(uploadpath))
                    {
                        Directory.CreateDirectory(uploadpath);
                    }
                    // create file Name
                    var uniqueName = Guid.NewGuid().ToString();
                    var ext = Path.GetExtension(file.FileName);
                    string imageName = uniqueName + ext;
                    var filepath = Path.Combine(uploadpath, imageName);

                    model.Image = Path.Combine(imgPath, imageName);

                    using (var filestream = new FileStream(filepath, FileMode.Create))
                    {
                        file.CopyTo(filestream);
                    }

                }


                UnitOfWork.ProductBL.Update(model);

                if (UnitOfWork.Complete(LoggedUserId) > 0)
                {
                    // success
                    return Json(new { Success = true, Message = ApplicationMessages.UpdateSuccess });
                }
                else
                {
                    return Json(new { Success = false, Message = ApplicationMessages.UpdateFailed });
                }

            }
            catch (Exception e)
            {
                return Json(new { Success = false, Message = "Exception", Error = e.Message });
                // error
            }
        }



        #endregion

        #region Active DeActive



        public ActionResult Deactivate(int productId)
        {

            var model = UnitOfWork.ProductBL.GetByID(productId);
            model.IsActive = false;

            UnitOfWork.ProductBL.Update(model);
            UnitOfWork.Complete(LoggedUserId);

            return RedirectToAction("Index");


        }

        public ActionResult Activate(int productId)
        {

            var model = UnitOfWork.ProductBL.GetByID(productId);
            model.IsActive = true;

            UnitOfWork.ProductBL.Update(model);
            UnitOfWork.Complete(LoggedUserId);

            return RedirectToAction("Index");


        }
        #endregion

        //[PermissionNotRequired]
        //public JsonResult GetAllDept()
        //{
        //    //Get ALL Dept in dropdown

        //    var Depts = UnitOfWork.DepartmentBL.GetAll().Select(c => new { id = c.Id, name = c.Name }).ToArray();

        //    return Json(Depts);
        //}

        //[PermissionNotRequired]
        //public JsonResult GetAllTypes()
        //{
        //    //Get ALL Types in dropdown

        //    var Types = UnitOfWork.ProductBL.ProductTypeList();
        //    return Json(Types);
        //}

        #region ExportProduct

        [HttpGet]
        public FileResult ExportProduct(ProductDTO obj)
        {
            List<Product> Result = null;
            if (LoggedIsSystemAdmin)
            {
                var stream = new MemoryStream();
                try
                {
                    var ProductList = SearchFun(obj);


                    var sheet = new List<ProductExport>();

                    foreach (var item in ProductList)
                    {
                        sheet.Add(new ProductExport() { Name = item.ProductName, Code = item.Code, DepartmentName = item.DepartmentName });

                    }
                    var ProdDT = Helper.GenerateDataTable(sheet.ToArray());

                    using (var wb = new XLWorkbook())
                    {
                        wb.Worksheets.Add(ProdDT, "Product");

                        wb.SaveAs(stream);
                        return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "product.xlsx");

                    }
                }
                catch (Exception e)
                {
                    return File(stream.ToArray(), e.ToString());

                }
            }




            else // normal user 
            {
                var stream = new MemoryStream();
                try
                {
                    var ProductList = SearchFun(obj);

                    var sheet = new List<ProductExport>();

                    foreach (var item in ProductList)
                    {
                        sheet.Add(new ProductExport() { Name = item.ProductName, Code = item.Code, DepartmentName = item.DepartmentName });

                    }
                    var ProdDT = Helper.GenerateDataTable(sheet.ToArray());

                    using (var wb = new XLWorkbook())
                    {
                        wb.Worksheets.Add(ProdDT, "Product");

                        wb.SaveAs(stream);
                        return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "product.xlsx");

                    }
                }
                catch (Exception e)
                {
                    return File(stream.ToArray(), e.ToString());

                }


            }
        }
        #endregion

        [PermissionNotRequired]
        public ActionResult ImportProduct()
        {
            return View();
        }

        public JsonResult UploadFiles(IFormFile Zip, IFormFile ProductsExcelFile)
        {
            var webRoot = _env.WebRootPath;
            string TempPath = Path.Combine(webRoot, "Uploads/Product/");
            // upload zip file
            #region upload zip file

            string ZipFileName = TempPath + Zip.FileName;
            if (Path.GetExtension(ZipFileName).Equals(".zip"))
            {
                using (var filestream = new FileStream(ZipFileName, FileMode.Create))
                {
                    Zip.CopyTo(filestream);
                }
                try
                {
                    using (var s = new ZipInputStream(System.IO.File.OpenRead(ZipFileName)))
                    {
                        ZipEntry theEntry;
                        while ((theEntry = s.GetNextEntry()) != null)
                        {
                            string directoryName = Path.GetDirectoryName(theEntry.Name);
                            string fileName = Path.GetFileName(theEntry.Name);

                            // create directory
                            if (fileName != String.Empty)
                            {
                                if (fileName.IndexOfAny(@"!@#$%^*/~\".ToCharArray()) > 0)
                                {
                                    continue;
                                }


                                using (FileStream streamWriter = System.IO.File.Create(TempPath + theEntry.Name))
                                {
                                    var data = new byte[2048];

                                    while (true)
                                    {
                                        int size = s.Read(data, 0, data.Length);

                                        if (size > 0)
                                            streamWriter.Write(data, 0, size);

                                        else
                                            break;

                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    return Json(new { Ok = false, message = "Empty File" });

                }
            }
            else
            {
                // ViewBag.noticZipFileUpload = "Empty File";
                return Json(new { Ok = false, message = "Empty File" });
            }

            #endregion

            // upload Sheet
            #region upload sheet

            if (ProductsExcelFile.Length > 0)
            {
                // extract only the filename
                var fileName = Path.GetFileName(ProductsExcelFile.FileName);
                string ext = Path.GetExtension(ProductsExcelFile.FileName);

                string NewFileName = "Products_" + DateTime.Now.ToShortDateString().Replace("/", "-") + "-" + DateTime.Now.ToShortTimeString().Replace(":", "-").Replace(" ", "-") + ext;

                fileName = NewFileName;

                var path = Path.Combine(TempPath, fileName);


                using (var wb = new XLWorkbook(ProductsExcelFile.OpenReadStream()))
                {
                    IXLWorksheet sheet;
                    try
                    {
                        wb.SaveAs(path);
                        wb.TryGetWorksheet("Sheet1", out sheet);
                        if (sheet != null)
                        {
                            // get last row
                            string lastrow = sheet.LastRowUsed().RangeAddress.FirstAddress.ToString();
                            lastrow = lastrow.Remove(0, 1);
                            var rowCount = int.Parse(lastrow);
                            // 2 beacuse header
                            var rowRange = sheet.Rows(2, rowCount).ToList();
                            var rowsCount = rowRange.Count();
                            // to get first row
                            var firstrowRange = sheet.Rows(1, 2).ToList();
                            var FirstRowcols = firstrowRange.ElementAt(0).Cells().ToList();


                            if (
                                FirstRowcols.ElementAt(0).Value.ToString() == "Product Name" &&
                                FirstRowcols.ElementAt(1).Value.ToString() == "Code" &&
                                FirstRowcols.ElementAt(2).Value.ToString() == "Image Name" &&
                                FirstRowcols.ElementAt(3).Value.ToString() == "Department" &&
                                FirstRowcols.ElementAt(4).Value.ToString() == "Amount")
                            {

                                if (rowsCount < 1000)
                                {
                                    List<Product> productList = new List<Product>();
                                    List<ProductError> lstErr = new List<ProductError>() { };


                                    var AllProduct = UnitOfWork.ProductBL.GetAllProductList()
                                                                .Where(p => p.IsActive == true)
                                                                 .ToList();


                                    for (int i = 0; i < rowsCount; i++)

                                    {
                                        Product product = new Product();
                                        ProductError err = new ProductError();
                                        string reason = string.Empty;

                                        var cols = rowRange.ElementAt(i).Cells().ToList();
                                        if (
                                            !string.IsNullOrEmpty(cols.ElementAt(0).Value.ToString())
                                            && !string.IsNullOrEmpty(cols.ElementAt(1).Value.ToString())
                                            && !string.IsNullOrEmpty(cols.ElementAt(2).Value.ToString())
                                            && !string.IsNullOrEmpty(cols.ElementAt(3).Value.ToString())
                                            && !string.IsNullOrEmpty(cols.ElementAt(4).Value.ToString())
                                            && !string.IsNullOrEmpty(cols.ElementAt(5).Value.ToString())

                                            )
                                        {
                                            product.Name = (string)cols.ElementAt(0).Value;
                                            product.InventoryQnty = Convert.ToDecimal(cols.ElementAt(5).Value);
                                            product.IsActive = true;
                                            product.CreatedDate = DateTime.Now;
                                            product.CreatedBy = LoggedUserId;

                                            // Department
                                            var department = AllProduct.Where(p => p.Department.Name.ToLower() == (string)cols.ElementAt(4).Value.ToString().ToLower())
                                                .FirstOrDefault();
                                            if (department != null)
                                            {
                                                product.DepartmentId = department.DepartmentId;
                                            }
                                            else
                                            {
                                                reason += "Department not exist, ";
                                            }

                                            // end
                                            // check unique name 
                                            if (AllProduct.Where(p => p.DepartmentId == department.DepartmentId && p.Name == (string)cols.ElementAt(0).Value).FirstOrDefault() == null)
                                            {
                                                product.Name = (string)cols.ElementAt(0).Value;
                                            }
                                            else
                                            {
                                                reason += "Name already exist,";
                                            }
                                            //Code
                                            if (AllProduct.Where(p => p.DepartmentId == department.DepartmentId  && p.Code == (string)cols.ElementAt(1).Value).FirstOrDefault() == null)
                                            {
                                                product.Code = (string)cols.ElementAt(1).Value;
                                            }
                                            else
                                            {
                                                reason += "Code already exist,";
                                            }


                                            //End

                                            //Type
                                            //if (POPEnums.ProductType.BBO.ToString().ToLower() == cols.ElementAt(2).Value.ToString().ToLower())
                                            //{
                                            //    product.TypeId = (int)POPEnums.ProductType.BBO;
                                            //}
                                            //else if (POPEnums.ProductType.Product.ToString().ToLower() == (string)cols.ElementAt(2).Value.ToString().ToLower())
                                            //{
                                            //    product.TypeId = (int)POPEnums.ProductType.Product;

                                            //}
                                            //else
                                            //{
                                            //    reason += "Type not exist,";
                                            //}
                                            //End

                                            // image
                                            if (System.IO.File.Exists(TempPath + cols.ElementAt(3).Value) == true)
                                            {

                                                // var uniqueId = Guid.NewGuid().ToString();

                                                product.Image = @"\Uploads\Product\" + (string)cols.ElementAt(3).Value;
                                            }
                                            else
                                            {
                                                reason += " Image not exist in product folder, ";
                                            }

                                            // end


                                           

                                        }
                                        else if (string.IsNullOrEmpty(cols.ElementAt(0).ToString()) || string.IsNullOrEmpty(cols.ElementAt(1).ToString()) || string.IsNullOrEmpty(cols.ElementAt(2).ToString()) || string.IsNullOrEmpty(cols.ElementAt(3).ToString()))
                                        {
                                            reason += " Empty Field,";
                                        }

                                        if (string.IsNullOrEmpty(reason))
                                        {
                                            if (!string.IsNullOrEmpty(product.Name) && !string.IsNullOrEmpty(product.Code))
                                            {
                                                productList.Add(product);
                                            }
                                        }
                                        else
                                        {
                                            err.Name = cols.ElementAt(0).Value.ToString();
                                            err.Code = cols.ElementAt(1).Value.ToString();
                                            //  err.Type = cols.ElementAt(2).Value.ToString();
                                            err.Image = cols.ElementAt(3).Value.ToString();
                                            err.Reason = reason;
                                            lstErr.Add(err);
                                        }
                                    }

                                    // export faild product
                                    //if (lstErr.Count > 0)
                                    //{
                                    //    ExportFaildProduct(lstErr);
                                    //}

                                    UnitOfWork.ProductBL.AddRange(productList);
                                    if (UnitOfWork.Complete(LoggedUserId) > 0)
                                    {


                                        return Json(new { Ok = true, Message = "Uploaded successfully", err = lstErr });
                                    }
                                    else
                                    {
                                        return Json(new { Ok = false, Message = "Incomplete Data", err = lstErr });
                                    }
                                }

                            }
                            else
                            {
                                return Json(new { Ok = false, Message = "Please download Tempelte", temp = true });

                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        return Json(new { Ok = false, Message = "Error" + ex });
                    }
                }

            }
            return Json(new { Ok = true });
            #endregion

        }

        // return faild records
        #region ExportFaildProduct

        [PermissionNotRequired]
        public FileResult ExportFaildProduct(List<ProductError> errorList)
        {
            using (var stream = new MemoryStream())
            {
                try
                {
                    var ProductList = errorList.Select(p => new ProductError
                    {

                        Code = p.Code,
                        Name = p.Name,
                        Image = p.Image,
                        Reason = p.Reason,
                        //Type = p.Type,
                    }).ToList();

                    var sheet = new List<ProductError>();


                    var ProdDT = Helper.GenerateDataTable(sheet.ToArray());

                    using (var wb = new XLWorkbook())
                    {
                        wb.Worksheets.Add(ProdDT, "FaildProduct");

                        wb.SaveAs(stream);

                        return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "FaildProduct.xlsx");
                    }
                }
                catch (Exception e)
                {
                    return File(stream.ToArray(), e.ToString());

                }
            }
        }
        #endregion


    }


}

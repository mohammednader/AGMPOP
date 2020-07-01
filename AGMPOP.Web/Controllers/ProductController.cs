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

        public List<ProductDTO> SearchProducts(ProductDTO obj)
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
                var Model = SearchProducts(obj);
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

            var product = UnitOfWork.ProductBL.GetProductWithDepartmentByid(Id);
            var model = new ProductVM
            {
                ProductId = product.ProductId,
                Name = product.Name,
                 Code = product.Code,
                CreatedBy = product.CreatedBy,
                CreatedDate = product.CreatedDate,
                Image = product.Image,
                InventoryQnty = product.InventoryQnty,
                DepartmentName = product.DepartmentName,
                DepartmentID = product.DepartmentID,
 
            };

            //if (UnitOfWork.ProductBL.CheckExist(p => p.Code == model.Code && p.DepartmentId == model.DepartmentID))
            //{
            //    ViewBag.DepartmentReadOnly = true;
            //}
            //else
            //{
            //    ViewBag.DepartmentReadOnly = false;
            //}
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
                 if (UnitOfWork.ProductBL.CheckExist(p => (p.ProductId != product.ProductId) &&(
                                            (p.Code == product.Code && p.DepartmentId == product.DepartmentID) ||
                                            (p.Name == product.Name && p.DepartmentId == product.DepartmentID))))
                {
                    return Json(new { Success = false, Message = "Code and name should be new" });
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


        #region ExportProduct

        [HttpGet]
        public FileResult ExportProduct(ProductDTO obj)
        {
            List<Product> Result = null;
            using (var stream = new MemoryStream())
                try
                {
                    var ProductList = SearchProducts(obj);
                    var sheet = new List<ProductExport>();

                    var LstToExport = ProductList
                                            .Select(p => new ProductExport(p))
                                            .ToArray();

                    var ProdDT = Helper.GenerateDataTable(LstToExport);

                    using (var wb = new XLWorkbook())
                    {
                        wb.Worksheets.Add(ProdDT, "Product");

                        wb.SaveAs(stream);
                        return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "product.xlsx");

                    }
                }
                catch (Exception e)
                {
                    return null;
                }

        }
        #endregion

        [PermissionNotRequired]
        public ActionResult ImportProduct()
        {
            return View();
        }
        
        internal struct PhotoStruct
        {
            public byte[] Binary { get; set; }
            public string GuidName { get; set; }
            public PhotoStruct(ref byte[] binary, string guidName) => (Binary, GuidName) = (binary, guidName);
        }

        [PermissionNotRequired]
        public async Task<JsonResult> UploadFiles(IFormFile Zip, IFormFile ProductsExcelFile)
        {
            var webRoot = _env.WebRootPath;
            string TempPath = Path.Combine(webRoot, "Uploads/Product/");
            // upload zip file
            #region upload zip file

            string ZipFileName = TempPath + Zip.FileName;
            var photos = new Dictionary<string, PhotoStruct>();
            if (Path.GetExtension(ZipFileName).Equals(".zip"))
            {
                try
                {
                    using (var s = new ZipInputStream(Zip.OpenReadStream()))
                    {
                        ZipEntry theEntry;
                        while ((theEntry = s.GetNextEntry()) != null)
                        {
                            string fileName = Path.GetFileName(theEntry.Name);

                            // create directory
                            if (fileName != String.Empty)
                            {
                                if (fileName.IndexOfAny(@"!@#$%^*/~\".ToCharArray()) > 0)
                                {
                                    continue;
                                }
                                var size = theEntry.Size;
                                var binary = new byte[size];
                                int readBytes = 0;
                                while (readBytes < size)
                                {
                                    var read = s.Read(binary, readBytes, Convert.ToInt32(size));
                                    readBytes += read;
                                }
                                var ext = Path.GetExtension(fileName);
                                var guidName = Guid.NewGuid().ToString() + ext;
                                photos.Add(fileName, new PhotoStruct(ref binary, guidName));
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

            if (ProductsExcelFile.Length > 0 && photos.Count > 0)
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
                            var FirstRowcols = firstrowRange[0].Cells().ToList();


                            if (
                                FirstRowcols[0].Value.ToString() == "Product Name" &&
                                FirstRowcols[1].Value.ToString() == "Code" &&
                                FirstRowcols[2].Value.ToString() == "Image Name" &&
                                FirstRowcols[3].Value.ToString() == "Department" &&
                                FirstRowcols[4].Value.ToString() == "Amount")
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
                                            !string.IsNullOrEmpty(cols[0].Value.ToString())
                                            && !string.IsNullOrEmpty(cols[1].Value.ToString())
                                            && !string.IsNullOrEmpty(cols[2].Value.ToString())
                                            && !string.IsNullOrEmpty(cols[3].Value.ToString())
                                            && !string.IsNullOrEmpty(cols[4].Value.ToString())

                                            )
                                        {
                                            product.InventoryQnty = Convert.ToDecimal(cols[4].Value);
                                            product.IsActive = true;
                                            product.CreatedDate = DateTime.Now;
                                            product.CreatedBy = LoggedUserId;

                                            // Department
                                            var department = AllProduct.Where(p => p.Department.Name.ToLower() == (string)cols[3].Value.ToString().ToLower())
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
                                            if (department != null)
                                            {

                                                // check unique name 
                                                if (AllProduct.Where(p => p.DepartmentId == department.DepartmentId && p.Name == cols.ElementAt(0).Value.ToString()).FirstOrDefault() == null)
                                                {
                                                    product.Name = cols[0].Value.ToString();
                                                }
                                                else
                                                {
                                                    reason += "Name already exist, ";
                                                }
                                                //Code
                                                if (AllProduct.Where(p => p.DepartmentId == department.DepartmentId && p.Code == cols[1].Value.ToString()).FirstOrDefault() == null)
                                                {
                                                    product.Code = cols[1].Value.ToString();
                                                }
                                                else
                                                {
                                                    reason += "Code already exist, ";
                                                }
                                            }


                                            //End


                                            // image
                                            string imageName = cols[2].Value.ToString();
                                            if (photos.ContainsKey(imageName))
                                            {
                                                var photoStruct = photos[imageName];
                                                var imagePath = Path.Combine("Uploads", "Product", photoStruct.GuidName);
                                                var fullpath = Path.Combine(webRoot, imagePath);
                                                try
                                                {
                                                    if (!System.IO.File.Exists(fullpath))
                                                    {
                                                        await System.IO.File.WriteAllBytesAsync(fullpath, photoStruct.Binary);
                                                    }
                                                    product.Image = @"\" + imagePath;
                                                }
                                                catch (Exception ex)
                                                {
                                                    reason += "Failed to save image, ";
                                                }
                                            }
                                            else
                                            {
                                                reason += "Image doesn't exist in zip file, ";
                                            }
                                            // end
                                        }
                                        else if (string.IsNullOrEmpty(cols[0].ToString()) || string.IsNullOrEmpty(cols[1].ToString()) || string.IsNullOrEmpty(cols[2].ToString()) || string.IsNullOrEmpty(cols[3].ToString()))
                                        {
                                            reason += "Empty Field, ";
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
                                            err.Name = cols[0].Value.ToString();
                                            err.Code = cols[1].Value.ToString();
                                            err.Image = cols[3].Value.ToString();
                                            err.Reason = reason;
                                            lstErr.Add(err);
                                        }
                                    }

                                    UnitOfWork.ProductBL.AddRange(productList);
                                    if (UnitOfWork.Complete(LoggedUserId) > 0)
                                    {
                                        return Json(new { Ok = true, Message = ApplicationMessages.SaveSuccess, err = lstErr });
                                    }
                                    else
                                    {
                                        return Json(new { Ok = false, Message = "Failed to import products", err = lstErr });
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
                        return Json(new { Ok = false, Message = ApplicationMessages.ErrorOccure });
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

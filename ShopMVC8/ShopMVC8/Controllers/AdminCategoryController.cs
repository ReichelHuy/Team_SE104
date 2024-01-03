using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopMVC8.ViewModels;
using ShopMVC8.Data;
using ShopMVC8.Helper;
using AutoMapper;
namespace ShopMVC8.Controllers
{   
    public class AdminCategoryController : Controller
    {
    private Hshop2023Context db = new Hshop2023Context();
    private readonly IMapper _mapper;
    
    public AdminCategoryController(Hshop2023Context context, IMapper mapper)
    {
            db = context;
            _mapper = mapper;
    }
        [Route("Admin/Category")]
        public IActionResult Index()
        {
            var items = db.HangHoas;

            return View(items);
        }

    
        
    [HttpGet]
    [Route("Admin/Category/Adding")]
        // Dang Ky
        public IActionResult Adding()
        {
            return View();
        }

    [HttpPost]
    [Route("Admin/Category/Adding")]
    public IActionResult Adding(QuanliHangHoaVM model, IFormFile Hinh)
        {
                if (ModelState.IsValid)
            {
                    var HangHoaMoi  = _mapper.Map<HangHoa>(model);
                    var category = _mapper.Map<Loai>(model);
                    var existingCategory = db.Loais.FirstOrDefault<Loai>(c => c.MaLoai == category.MaLoai);
                    if (existingCategory == null)
                    {
                        db.Add(category);
                        db.SaveChanges();
                    }
                    HangHoaMoi.SoLanXem = 0 ; 
                    // Kiểm tra và xử lý hình ảnh
                    if (Hinh != null)
                    {
                      HangHoaMoi.Hinh = Util.UpLoadHinh(Hinh, "HangHoa");
                    }
                    // Thêm hàng hoá mới
                    db.Add(HangHoaMoi);
                    db.SaveChanges();
                    // Redirect đến trang quản lí
                    return RedirectToAction("Index", "AdminCategory");
                }

            return View();
        }
        [HttpGet]
        [Route("Admin/Category/Edit")]
        public IActionResult Edit(QuanliHangHoaVM model)
        {
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        [HttpPost]
        [Route("Admin/Category/Edit")]
        public IActionResult Edit(QuanliHangHoaVM model, IFormFile Hinh)
        {
            if (ModelState.IsValid)
            {
                var HangHoaMoi = _mapper.Map<HangHoa>(model);
                var category = _mapper.Map<Loai>(model);
                var existingCategory = db.Loais.FirstOrDefault<Loai>(c => c.MaLoai == category.MaLoai);
                if (existingCategory != null)
                {
                    db.Update(category);
                    db.SaveChanges();
                }
                HangHoaMoi.SoLanXem = 0;
                // Kiểm tra và xử lý hình ảnh
                if (Hinh != null)
                {
                    HangHoaMoi.Hinh = Util.UpLoadHinh(Hinh, "HangHoa");
                }
                // Thêm hàng hoá mới
                db.Update(HangHoaMoi);
                db.SaveChanges();
                // Redirect đến trang quản lí
                return RedirectToAction("Index", "AdminCategory");
            }
                return View();
        }

        
        [HttpPost]
        [Route("Admin/Category/Delete")]
        public IActionResult Delete(QuanliHangHoaVM model)
        { if (ModelState.IsValid)
            {
                var hangHoa = _mapper.Map<HangHoa>(model);

                // Xóa hàng hoá
                db.Remove(hangHoa);
                db.SaveChanges();

                // Redirect đến trang quản lý
                return RedirectToAction("Index", "AdminCategory");
            }
        return View();
        }
       

    }
}
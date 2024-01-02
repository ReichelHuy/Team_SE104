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
        public IActionResult Index()
        {
            var items = db.HangHoas.ToList(); // Lấy danh sách sản phẩm từ cơ sở dữ liệu

            // Map danh sách sản phẩm sang ViewModel nếu cần thiết
            var model = _mapper.Map<List<QuanliHangHoaVM>>(items);

            return View(model);
        }

        [Route("Admin/Category")]
        
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
                try
                {
                    var HangHoaMoi  = _mapper.Map<HangHoa>(model);
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
                catch (Exception) {  }
            }
            return View();
        }
        [HttpGet]
        [Route("Admin/Category/Edit/{id}")]
        public IActionResult Edit(int id)
        {
            var hangHoa = db.HangHoas.Find(id);

            if (hangHoa == null)
            {
                return NotFound();
            }

            var model = _mapper.Map<QuanliHangHoaVM>(hangHoa);
            return View(model);
        }

        [HttpPost]
        [Route("Admin/Category/Edit/{id}")]
        public IActionResult Edit(int id, QuanliHangHoaVM model, IFormFile Hinh)
        {
            if (id != model.MaHh)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var hangHoa = _mapper.Map<HangHoa>(model);

                    // Kiểm tra và xử lý hình ảnh
                    if (Hinh != null)
                    {
                        hangHoa.Hinh = Util.UpLoadHinh(Hinh, "HangHoa");
                    }

                    // Cập nhật hàng hoá
                    db.Update(hangHoa);
                    db.SaveChanges();

                    // Redirect đến trang quản lí
                    return RedirectToAction("Index", "AdminCategory");
                }
                catch (Exception)
                {
                    // Xử lý ngoại lệ
                }
            }

            return View(model);
        }

        [HttpGet]
        [Route("Admin/Category/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var hangHoa = db.HangHoas.Find(id);

            if (hangHoa == null)
            {
                return NotFound();
            }

            var model = _mapper.Map<QuanliHangHoaVM>(hangHoa);
            return View(model);
        }

        [HttpPost]
        [Route("Admin/Category/Delete/{id}")]
        public IActionResult DeleteConfirmed(int id)
        {
            var hangHoa = db.HangHoas.Find(id);

            if (hangHoa == null)
            {
                return NotFound();
            }

            // Xóa hàng hoá
            db.Remove(hangHoa);
            db.SaveChanges();

            // Redirect đến trang quản lí
            return RedirectToAction("Index", "AdminCategory");
        }


    }
}
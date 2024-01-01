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

    }
}
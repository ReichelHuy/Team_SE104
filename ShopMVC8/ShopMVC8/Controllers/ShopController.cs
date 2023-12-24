using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopMVC8.ViewModels;
using ShopMVC8.Data;
using ShopMVC8.Models;

namespace ShopMVC8.Controllers
{
    [Route("[controller]")]
    public class ShopController : Controller
    {
        private readonly Hshop2023Context db;
        public ShopController(Hshop2023Context context)
        {
            db = context;
        }
        [HttpGet]
        public IActionResult Index(int? loai)
        {
           var Items = db.HangHoas.AsQueryable();
           if (loai.HasValue) {Items = Items.Where(p => p.MaLoai == loai.Value);}

            var result = Items.Select(p => new HangHoaVM 
        { 
            MaHh = p.MaHh,
            TenHh = p.TenHh ,
            DonGia = p.DonGia ?? 0,
            Hinh = p.Hinh ?? "",
            TenLoai = p.MaLoaiNavigation.TenLoai
         });
           return View("Shop",result);
        }

        public IActionResult Search(string? query)
        {
            var Items = db.HangHoas.AsQueryable();
            if (query != null)
            {
                Items = Items.Where(p => p.TenHh.Contains(query));
            }
            var result = Items.Select(p => new HangHoaVM 
            { 
            MaHh = p.MaHh,
            TenHh = p.TenHh ,
            DonGia = p.DonGia ?? 0,
            Hinh = p.Hinh ?? "",
            TenLoai = p.MaLoaiNavigation.TenLoai
            });
           return View("Shop",result);
        }
    }
}
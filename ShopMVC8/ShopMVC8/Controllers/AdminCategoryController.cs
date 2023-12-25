using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopMVC8.Data;

namespace ShopMVC8.Controllers
{
    
    public class AdminCategoryController : Controller
    {
    private Hshop2023Context db = new Hshop2023Context();

    [Route("Admin/Category")]
        public IActionResult Index()
        {
            var items = db.HangHoas;
            return View(items);
        }
    
    [Route("Admin/Category/Adding")]
        public IActionResult Adding()
        {
            return View();
        }

    }
}
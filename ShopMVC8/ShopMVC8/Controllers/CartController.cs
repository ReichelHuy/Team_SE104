using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShopMVC8.Data;
using ShopMVC8.ViewModels;
using ShopMVC8.Helper;
using Microsoft.AspNetCore.Http;

namespace ShopMVC8.Controllers
{
    public class CartController : Controller
    {
        private readonly Hshop2023Context db;

        public CartController(Hshop2023Context context)
        {
            db = context;
        }
        const string CART_KEY = "MYCART";
        public List<CartItem> Cart => HttpContext.Session.Get<List<CartItem>>(CART_KEY) ?? new List<CartItem>();

        public IActionResult Index()
        {
            return View(Cart);
        }
        public IActionResult AddToCart(int id, int quantity = 1)
        {
            var giohang = Cart;
            var item = giohang.SingleOrDefault(p => p.MaHh == id);
            if (item == null)
            {
                var hangHoa = db.HangHoas.SingleOrDefault(p => p.MaHh == id);
                if (hangHoa == null)
                {
                    TempData["Message"] = $"Không tìm thấy mặt hàng";
                    return Redirect("/404");
                }
                item = new CartItem
                {
                    MaHh = hangHoa.MaHh,
                    TenHh = hangHoa.TenHh,
                    DonGia = hangHoa.DonGia ?? 0,
                    Hinh = hangHoa.Hinh ?? string.Empty,
                    SoLuong = quantity


                };
                giohang.Add(item);
            }
            else
            {
                item.SoLuong += quantity;
            }

            HttpContext.Session.Set(CART_KEY, giohang);
            return RedirectToAction("Index");

            return View();
        }
        public IActionResult RemoveCart(int id)
        {
            var gioHang = Cart;
            var item = gioHang.SingleOrDefault(p => p.MaHh == id);
            if (item != null)
            {
                gioHang.Remove(item);
                HttpContext.Session.Set(CART_KEY, gioHang);
            }
            return RedirectToAction("Index");

        }
    }
}

using BaiTapKiemTra01.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiTapKiemTra01.Controllers
{
    public class SanPhamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
   
            public IActionResult BaiTap2()
            {
                var sanPham = new SanPhamViewModel
                {
                    TenSanPham = "LapTop",
                    GiaBan = 15000000,
                    HinhAnh = "/images/2108_man-hinh-laptop-lenovo.jpg"
                };

                return View(sanPham);
            }
        }
}

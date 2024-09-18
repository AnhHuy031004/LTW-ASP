using BaiTapKiemTra01.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiTapKiemTra01.Controllers
{
    public class TaiKhoanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ĐangKy(TaiKhoanViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Hiển thị thông tin
                return Content($"Tên tài khoản: {model.TaiKhoan}, Mật khẩu: {model.MatKhau}, Họ tên: {model.HoTen}, Tuổi: {model.Tuoi}");
            }

            return View(model); 
        }
    }
}

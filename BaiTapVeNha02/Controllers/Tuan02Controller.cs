using Microsoft.AspNetCore.Mvc;

namespace BaiTapVeNha02.Controllers
{
    public class Tuan02Controller : Controller
    {
        public ActionResult Index()
        {
            ViewBag.HoTen = "Hoàng Anh Huy";
            ViewBag.MSSV = "1822040269";
            ViewBag.Nam = 2024;

            return View();
        }
    }
}

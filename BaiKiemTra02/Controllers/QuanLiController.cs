using BaiKiemTra02.Data;
using BaiKiemTra02.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiKiemTra02.Controllers
{
    public class QuanLiController : Controller
    {
        private readonly ApplicationDbContext _db;
        public QuanLiController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var quanli = _db.QuanLi.ToList();
            ViewBag.QuanLi = quanli;

            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(QuanLi quanli)
        {
            if (ModelState.IsValid)
            {
               
                _db.QuanLi.Add(quanli);
                
                _db.SaveChanges();
                
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var quanli = _db.QuanLi.Find(id);

            return View(quanli);
        }

        [HttpPost]
        public IActionResult Edit(QuanLi quanli)
        {
            if (ModelState.IsValid)
            {
               
                _db.QuanLi.Update(quanli);
                // Lưu lại
                _db.SaveChanges();
              
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var quanli = _db.QuanLi.Find(id);
            return View(quanli);
        }

        [HttpPost]
        public IActionResult DeleteConform(int id)
        {
            var quanli = _db.QuanLi.Find(id);
            if (quanli == null)
            {
                return NotFound();
            }
            _db.QuanLi.Remove(quanli);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Detail(int id)
        {


            var quanli = _db.QuanLi.Find(id);
            if (quanli == null)
            {
                return NotFound();
            }

            return View(quanli);
        }
        [HttpGet]
        public IActionResult Search(string searchString)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
              
                var quanli = _db.QuanLi.
                    Where(tl => tl.Name.Contains(searchString)).ToList();
                ViewBag.searchString = searchString;
                ViewBag.QuanLi = quanli;

            }
            else
            {
                var quanli = _db.QuanLi.ToList();
                ViewBag.QuanLi = quanli;
            }
            return View("Index");
        }
    }
}

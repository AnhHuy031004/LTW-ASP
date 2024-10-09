using BaiKiemTra03_03.Data;
using BaiKiemTra03_03.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiKiemTra03_03.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CustomerController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var customer = _db.Customer.ToList();
            ViewBag.Customer = customer;

            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                // Thêm thông tin vào bảng 
                _db.Contract.Add(customer);
                // Lưu lại
                _db.SaveChanges();
                // Chuyển trang về index
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
            var customer = _db.Customer.Find(id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                // Thêm thông tin vào bảng TheLoai
                _db.Contract.Update(customer);
                // Lưu lại
                _db.SaveChanges();
                // Chuyển trang về index
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
            var customer = _db.Customer.Find(id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult DeleteConform(int id)
        {
            var customer = _db.Customer.Find(id);
            if (customer == null)
            {
                return NotFound();
            }
            _db.Contract.Remove(customer);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Detail(int id)
        {


            var customer = _db.Customer.Find(id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }
        [HttpGet]
        public IActionResult Search(string searchString)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                //Sử Dụng LINQ
                var customer = _db.Customer.
                    Where(tl => tl.Name.Contains(searchString)).ToList();
                ViewBag.searchString = searchString;
                ViewBag.Customer = customer;

            }
            else
            {
                var customer = _db.Customer.ToList();
                ViewBag.Customer = customer;
            }
            return View("Index");
        }
    }
}


using BaiKiemTra03_03.Data;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;

namespace BaiKiemTra03_03.Controllers
{
    public class ContractController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ContractController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var contract = _db.Contract.ToList();
            ViewBag.Contract = contract;

            return View(contract);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contract contract)
        {
            if (ModelState.IsValid)
            {
                // Thêm thông tin vào bảng 
                _db.Contract.Add(contract);
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
            var contract = _db.Contract.Find(id);
            return View(contract);
        }

        [HttpPost]
        public IActionResult Edit(Contract contract)
        {
            if (ModelState.IsValid)
            {
                // Thêm thông tin vào bảng TheLoai
                _db.Contract.Update(contract);
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
            var contract = _db.Contract.Find(id);
            return View(contract);
        }

        [HttpPost]
        public IActionResult DeleteConform(int id)
        {
            var contract = _db.Contract.Find(id);
            if (contract == null)
            {
                return NotFound();
            }
            _db.Contract.Remove(contract);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Detail(int id)
        {


            var contract = _db.Contract.Find(id);
            if (contract == null)
            {
                return NotFound();
            }

            return View(contract);
        }
        [HttpGet]
        public IActionResult Search(string searchString)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                //Sử Dụng LINQ
                var contract = _db.Contract.
                    Where(tl => tl.Name.Contains(searchString)).ToList();
                ViewBag.searchString = searchString;
                ViewBag.Contract = contract;

            }
            else
            {
                var contract = _db.Contract.ToList();
                ViewBag.Contract = contract;
            }
            return View("Index");
        }
    }
}


using HongTam.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Security.Claims;

namespace HongTam.Controllers
{
    public class DangNhapController : Controller
    {
        HongTamSolutionContext db = new HongTamSolutionContext();
        [HttpGet]
        public IActionResult Login()
        {
            return View ();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string taiKhoan , string matKhau)
        {
            if (ModelState.IsValid)
            {
                var check = db.TaiKhoans.Where(s => s.TaiKhoan1.Equals(taiKhoan) &&
            s.MatKhau.Equals(matKhau) && s.TrangThai == "Đã Kích Hoạt").ToList();

                if (check != null)
                {
                    HttpContext.Session.SetString("TenAdmin",check.FirstOrDefault().TenAdmin);
                  

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.err = "Tài Khoản Chưa Đăng kí";
                    return RedirectToAction("Login");
                }
            }
            return View();
        }
    }
}

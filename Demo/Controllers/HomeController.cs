using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Demo.Models;
using System.Text.RegularExpressions;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Index(PersonViewModel model)
        {
            //if (string.IsNullOrEmpty(model.Name))
            //{
            //    ModelState.AddModelError("Name", "نام را وارد کنید");
            //}
            //if (!string.IsNullOrEmpty(model.Name))
            //    {
            //    if (model.Name.Length < 5 || model.Name.Length > 20)
            //    {
            //        ModelState.AddModelError("Name", "طول نام معتبر نیست");
            //    }
            //}

            //string pattern = @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";


            //if (!Regex.IsMatch(model.Email, pattern, RegexOptions.IgnoreCase))
            //{
            //    ModelState.AddModelError("Email", "ایمیل درست نیست");
            //}

            //if (string.IsNullOrEmpty(model.Password))
            //{
            //    ModelState.AddModelError("Name", "Password Empty");
            //}
            //if (model.Age==0)
            //{
            //    ModelState.AddModelError("Age", "Age Empty");
            //}

            //if (model.Accept == false)
            //{
            //    ModelState.AddModelError("Accept", "لطفا با شرایط موافت کنید");
            //}

            if (ModelState.IsValid)
            {
                return RedirectToAction("Profile");
            }
     

            return View(model);
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Test([FromForm]string accept)
        {
            return Json(true);
        }


        public JsonResult CheckUserName(string Name)
        {
            if (Name=="rezaaaa")
            {
                return Json(false);
            }
            return Json(true);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

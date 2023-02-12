using System;
using Microsoft.AspNetCore.Mvc;
using mvc3.Models;

namespace mvc3.Controllers{
    public class NhanVien : Controller {
        public IActionResult GetNhanViens(){
            DataContext db = HttpContext.RequestServices.GetService(typeof(mvc3.Models.DataContext)) as DataContext;
            return View(
                db.GetNhanViens()
            );
        }
    }
}
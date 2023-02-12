using System;
using Microsoft.AspNetCore.Mvc;
using mvc3.Models;

namespace mvc3.Controllers{
    public class CanHoController : Controller {

       
        public IActionResult EnterCH(){
            return View();
        }

        public IActionResult InsertCH(CanHo ch){
            DataContext db = HttpContext.RequestServices.GetService(typeof(mvc3.Models.DataContext)) as DataContext;
            int count = db.InsertCH(ch);
            if(count > 0){
               ViewData["ThongBao"] = "Them Thanh Cong";
            }
            else{
                ViewData["ThongBao"] = "Them That Bai";
            }
            return View();
        }


    }
}
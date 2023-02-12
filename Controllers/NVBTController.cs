using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using mvc3.Models;

namespace mvc3.Controllers{
    public class NVBT : Controller{
        public IActionResult ShowList(){
            return View();
        }

        // public List<object> GetList(int SoLanSua){
        //     DataContext db = HttpContext.RequestServices.GetService(typeof(mvc3.Models.DataContext)) as DataContext;
        //     return db.GetListNVBT(SoLanSua);
        // }
        
        public IActionResult GetList(int SoLanSua){
            DataContext db = HttpContext.RequestServices.GetService(typeof(mvc3.Models.DataContext)) as DataContext;
           
            
            return View(
                db.GetListNVBT(SoLanSua)
            );

        }


        public IActionResult LietKe(string MaNhanVien){
            DataContext db = HttpContext.RequestServices.GetService(typeof(mvc3.Models.DataContext)) as DataContext;    
            return View(
                db.GetListNVBT(MaNhanVien)
            );
        }

        public IActionResult Delete(string MaNhanVien, string MaThietBi, string MaCanHo, string LanThu){
            DataContext db = HttpContext.RequestServices.GetService(typeof(mvc3.Models.DataContext)) as DataContext;
            int count = db.DeleteNVBT(MaNhanVien, MaThietBi, MaCanHo, LanThu);
            if(count > 0){
                ViewData["Message"] = "Xóa thành công";
            }
            else{
                ViewData["Message"] = "Xóa thất bại";
            }
            return View();
            
        }

        public IActionResult ViewNVBT(string MaNhanVien, string MaThietBi, string MaCanHo, string LanThu){
            DataContext db = HttpContext.RequestServices.GetService(typeof(mvc3.Models.DataContext)) as DataContext;
            return View(
                db.ViewNVBT(MaNhanVien, MaThietBi, MaCanHo, LanThu)
            );
        }

        public IActionResult UpdateNVBT(string MaNhanVien){
            string MaThietBi = Request.Form["MaThietBi"];
            string MaCanHo = Request.Form["MaCanHo"];
            string LanThu = Request.Form["LanThu"];
            string NgayBaoTri = Request.Form["NgayBaoTri"].ToString();
            
            DataContext db = HttpContext.RequestServices.GetService(typeof(mvc3.Models.DataContext)) as DataContext;

            int count = db.UpdateNVBT(MaNhanVien, MaThietBi, MaCanHo, LanThu, NgayBaoTri);
            if(count > 0){
                ViewData["Message"] = "Cập nhật thành công";
            }
            else{
                ViewData["Message"] = "Cập nhật thất bại";
            }
            return View();
        }


    }
}
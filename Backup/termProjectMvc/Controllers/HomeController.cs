using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using termProjectMvc.Models;
using termProjectMvc.Controllers;
namespace termProjectMvc.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        Database1Entities6 cx = new Database1Entities6();
        Iuser usr;
        Iproduct p;
        public HomeController(Iuser u, Iproduct p1)
        {
            usr = u;
            p = p1;
        }
        public ActionResult Index()
        {
            return View(cx.products.ToList());
        }
        public ViewResult aboutus()
        {
            return View();
        }
        public ViewResult contactus()
        {
            return View();
        }
        public ViewResult feedback()
        {
            return View();
        }
        public ViewResult login()
        {
            return View();
        }
        public ViewResult signup()
        {
            return View();
        }
        public ViewResult details(int id)
        {
            var v = p.edit(id);
            return View(v);
        }
        public JsonResult CheckUserName()
        {

            string userName = Request["n"];
            bool flag = false;
             flag = cx.user1.Any(x => x.username == userName );

            return this.Json(flag, JsonRequestBehavior.AllowGet);

        }
        public ViewResult test()
        {
            return View(cx.products.ToList());
        }
        public ActionResult search(int PriceRange)
        {
            ViewBag.Range = PriceRange;
            return View();
        }
        public JsonResult CheckproductRange(int Range)
        {

            // int range = Int32.Parse(Request["range"]);
            return this.Json(p.getList(Range), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult addMember(user1 user)
        {

            if (ModelState.IsValid)
            {
                usr.save(user);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("signup");
            }
           // return View("~/views/account/Register.cshtml");
           
        }
        public ActionResult validate(user user)
        {
            bool flag = cx.users.Any(x => x.name == user.name && x.password == user.password);
            if (flag)
            {  
                return Redirect("~/Admin/adminView");
            }
            return RedirectToAction("login");
        }
        
    }
}

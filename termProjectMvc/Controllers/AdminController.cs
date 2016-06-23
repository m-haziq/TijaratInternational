using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using termProjectMvc.Models;

namespace termProjectMvc.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        Database1Entities6 cx = new Database1Entities6();
        Iproduct pro;
        public AdminController(Iproduct p)
        {
            pro = p;
        }
        public ActionResult adminView()
        {
            return View(cx.products.ToList());
        }
        public ActionResult viewDetail()
        {
            return View();
        }
        public ActionResult search()
        {
            return View();
        }
        public ActionResult addProduct()
        {
            return View();
        }
        public ViewResult all_products()
        {
            List<product> li = pro.show();
            return View(li);
        }
        public ActionResult Edit(int id)
        {
            var v = pro.edit(id);
            return View(v);
        }

        [HttpPost]
        public ActionResult save(product p)
        {
             HttpPostedFileBase file = null;
            for (int i = 0; i < Request.Files.Count; i++)
            {
                file = Request.Files[i];
                file.SaveAs(Server.MapPath(@"~/Files/" + file.FileName));
            }
            string filename = @"/Files/" + file.FileName;
            //p.imageName = filename;
            String b = Request["br"];
            String cat = Request["c1"];
            pro.save(p, cat, b, filename);
            return RedirectToAction("adminView");
        }
        

        public ActionResult delete(int id)
        {
            pro.delete(id);
            return RedirectToAction("all_products");
        }
        public ActionResult updateconfirm(product p)
        {
            String c = Request["category"];
            String b = Request["br"];
            pro.update(p, c, b);
            return RedirectToAction("adminView");

        }
    }
}

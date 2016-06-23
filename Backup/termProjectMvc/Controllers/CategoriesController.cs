using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using termProjectMvc.Models;
namespace termProjectMvc.Controllers
{
    public class CategoriesController : Controller
    {
        //
        // GET: /Categories/
        Database1Entities6 db = new Database1Entities6();
        public ActionResult cellphones()
        {
            List<product> li = new List<product>();
            List<product> p = db.products.ToList();
            foreach (var x in p)
            {
                if (x.cid_ == 1)
                {
                    li.Add(x);
                }
            }
            //return li;
            return View(li);
        }
        public ActionResult laptops()
        {
            List<product> li = new List<product>();
            List<product> p = db.products.ToList();
            foreach (var x in p)
            {
                if (x.cid_ == 2)
                {
                    li.Add(x);
                }
            }
            //return li;
            return View(li);
        }
        public ActionResult tablets()
        {
            List<product> li = new List<product>();
            List<product> p = db.products.ToList();
            foreach (var x in p)
            {
                if (x.cid_ == 3)
                {
                    li.Add(x);
                }
            }
            //return li;
            return View(li);
        }
        public ActionResult cameras()
        {
            List<product> li = new List<product>();
            List<product> p = db.products.ToList();
            foreach (var x in p)
            {
                if (x.cid_ == 4)
                {
                    li.Add(x);
                }
            }
            //return li;
            return View(li);
        }
        public ActionResult computeracc()
        {
            List<product> li = new List<product>();
            List<product> p = db.products.ToList();
            foreach (var x in p)
            {
                if (x.cid_ == 5)
                {
                    li.Add(x);
                }
            }
            return View(li);
        }
        public ActionResult all()
        {
            List<product> li = new List<product>();
            List<product> p = db.products.ToList();
            foreach (var x in p)
            {
                if (x.cid_ == 4)
                {
                    li.Add(x);
                }
            }
            return View(li);
        }

    }
}

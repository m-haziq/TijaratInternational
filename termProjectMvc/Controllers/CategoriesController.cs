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
        public ActionResult adab()
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
        public ActionResult biography()
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
        public ActionResult childeren()
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
        public ActionResult islamic()
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
        public ActionResult novels()
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
        public ActionResult stories()
        {
            List<product> li = new List<product>();
            List<product> p = db.products.ToList();
            foreach (var x in p)
            {
                if (x.cid_ == 6)
                {
                    li.Add(x);
                }
            }
            return View(li);
        }
        public ActionResult comedy()
        {
            List<product> li = new List<product>();
            List<product> p = db.products.ToList();
            foreach (var x in p)
            {
                if (x.cid_ == 7)
                {
                    li.Add(x);
                }
            }
            return View(li);
        }
        public ActionResult computer()
        {
            List<product> li = new List<product>();
            List<product> p = db.products.ToList();
            foreach (var x in p)
            {
                if (x.cid_ == 8)
                {
                    li.Add(x);
                }
            }
            return View(li);
        }
        public ActionResult technology()
        {
            List<product> li = new List<product>();
            List<product> p = db.products.ToList();
            foreach (var x in p)
            {
                if (x.cid_ == 9)
                {
                    li.Add(x);
                }
            }
            return View(li);
        }
        public ActionResult programming()
        {
            List<product> li = new List<product>();
            List<product> p = db.products.ToList();
            foreach (var x in p)
            {
                if (x.cid_ == 10)
                {
                    li.Add(x);
                }
            }
            return View(li);
        }
        public ActionResult science()
        {
            List<product> li = new List<product>();
            List<product> p = db.products.ToList();
            foreach (var x in p)
            {
                if (x.cid_ == 11)
                {
                    li.Add(x);
                }
            }
            return View(li);
        }
        public ActionResult poetry()
        {
            List<product> li = new List<product>();
            List<product> p = db.products.ToList();
            foreach (var x in p)
            {
                if (x.cid_ == 12)
                {
                    li.Add(x);
                }
            }
            return View(li);
        }
        public ActionResult fashion()
        {
            List<product> li = new List<product>();
            List<product> p = db.products.ToList();
            foreach (var x in p)
            {
                if (x.cid_ == 13)
                {
                    li.Add(x);
                }
            }
            return View(li);
        }
        public ActionResult showbiz()
        {
            List<product> li = new List<product>();
            List<product> p = db.products.ToList();
            foreach (var x in p)
            {
                if (x.cid_ == 14)
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

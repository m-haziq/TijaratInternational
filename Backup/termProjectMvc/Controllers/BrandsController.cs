using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using termProjectMvc.Models;

namespace termProjectMvc.Controllers
{

    public class BrandsController : Controller
    {
        //
        // GET: /Filters/
        Database1Entities6 db = new Database1Entities6();
        public ActionResult apple()
        {
            List<product> li = new List<product>();
            List<product> p = db.products.ToList();
            foreach (var x in p)
            {
                if (x.bid == 1)
                {
                    li.Add(x);
                }
            }
            //return li;
            return View(li);
        }
        public ActionResult htc()
        {
            List<product> li = new List<product>();
            List<product> p = db.products.ToList();
            foreach (var x in p)
            {
                if (x.bid == 2)
                {
                    li.Add(x);
                }
            }
            //return li;
            return View(li);
        }
        public ActionResult samsung()
        {
            List<product> li = new List<product>();
            List<product> p = db.products.ToList();
            foreach (var x in p)
            {
                if (x.bid == 3)
                {
                    li.Add(x);
                }
            }
            //return li;
            return View(li);
        }
        public ActionResult android()
        {
            List<product> li = new List<product>();
            List<product> p = db.products.ToList();
            foreach (var x in p)
            {
                if (x.bid == 4)
                {
                    li.Add(x);
                }
            }
            //return li;
            return View(li); ;
        }
        public ActionResult nokia()
        {
            List<product> li = new List<product>();
            List<product> p = db.products.ToList();
            foreach (var x in p)
            {
                if (x.bid == 5)
                {
                    li.Add(x);
                }
            }
            //return li;
            return View(li);
        }
        public ActionResult canon()
        {
            List<product> li = new List<product>();
            List<product> p = db.products.ToList();
            foreach (var x in p)
            {
                if (x.bid == 7)
                {
                    li.Add(x);
                }
            }
            //return li;
            return View(li);
        }
        public ActionResult nikon()
        {
            List<product> li = new List<product>();
            List<product> p = db.products.ToList();
            foreach (var x in p)
            {
                if (x.bid == 8)
                {
                    li.Add(x);
                }
            }
            //return li;
            return View(li);
        }
        public ActionResult dell()
        {
            List<product> li = new List<product>();
            List<product> p = db.products.ToList();
            foreach (var x in p)
            {
                if (x.bid == 6)
                {
                    li.Add(x);
                }
            }
            //return li;
            return View(li);
        }
    }
}

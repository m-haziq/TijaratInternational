using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using termProjectMvc.Models;
namespace termProjectMvc.Controllers
{
    public class PriceController : Controller
    {
        //
        // GET: /Price/
        Database1Entities6 db = new Database1Entities6();
        public ActionResult one()
        {
            
            List<product> li = new List<product>();
            List<product> p = db.products.ToList();
            int pr;
            foreach (var x in p)
            {

                pr = Int32.Parse(x.price);
                if (pr >0 && pr <= 10000)
                {
                    li.Add(x);
                }
            }
            //return li;
            return View(li);
        }
         public ActionResult two()
        {
            List<product> li = new List<product>();
            List<product> p = db.products.ToList();
            int pr;
            foreach (var x in p)
            {

                pr = Int32.Parse(x.price);
                if (pr > 10000 && pr <= 20000)
                {
                    li.Add(x);
                }
            }
            //return li;
            return View(li);
        }
         public ActionResult three()
         {
             List<product> li = new List<product>();
             List<product> p = db.products.ToList();
             int pr;
             foreach (var x in p)
             {

                 pr = Int32.Parse(x.price);
                 if (pr > 20000 && pr <= 35000)
                 {
                     li.Add(x);
                 }
             }
             //return li;
             return View(li);
         }
         public ActionResult four()
         {
             List<product> li = new List<product>();
             List<product> p = db.products.ToList();
             int pr;
             foreach (var x in p)
             {

                 pr = Int32.Parse(x.price);
                 if (pr > 35000 && pr <= 45000)
                 {
                     li.Add(x);
                 }
             }
             //return li;
             return View(li);
         }
         public ActionResult five()
         {
             List<product> li = new List<product>();
             List<product> p = db.products.ToList();
             int pr;
             foreach (var x in p)
             {

                 pr = Int32.Parse(x.price);
                 if (pr > 45000  && pr <= 60000)
                 {
                     li.Add(x);
                 }
             }
             //return li;
             return View(li);
         }
         public ActionResult six()
         {
             List<product> li = new List<product>();
             List<product> p = db.products.ToList();
             int pr;
             foreach (var x in p)
             {

                 pr = Int32.Parse(x.price);
                 if (pr > 60000 )
                 {
                     li.Add(x);
                 }
             }
             //return li;
             return View(li);
         }


    }
}

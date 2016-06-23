using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace termProjectMvc.Models
{
    public class ProductRepo : Iproduct
    {
        Database1Entities6 db = new Database1Entities6();
        public ProductRepo()
        {
            db.Configuration.ProxyCreationEnabled = false;
        }
        public void save(product p, String c, String b, String f)
        {
            category cat1 = db.categories.First(x => x.name.Equals(c));
            //brand br = db.brands.First(x => x.name == b);
            p.cid_ = cat1.Id;
            //p.bid = br.Id;
            p.imageName = f;
            db.products.Add(p);
            db.SaveChanges();
    
        }
        public void delete(int id)
        {
            product p = db.products.First(x => x.Id == id);
            db.products.Remove(p);
            db.SaveChanges();
        }
        public List<product> show()
        {
            List<product> li = new List<product>();
            li = db.products.ToList();
            return li;
        }
        public product edit(int id)
        {
            product p = db.products.First(x => x.Id == id);
            return p;
        }
        public void update(product p, string c, string b)
        {
            var a = db.products.First(x => x.Id == p.Id);
            var ca = db.categories.First(x => x.name == c);
            var ba = db.brands.First(x => x.name == b);
            a.cid_ = ca.Id;
            a.bid = ba.Id;
            a.title = p.title;
            a.price = p.price;
            db.SaveChanges();
 
        }
        public List<product> getList(int range)
        {
            List<product> temp = new List<product>();
            List<product> p = db.products.ToList();
            
            foreach (var x in p)
            {
                int price = Int32.Parse(x.price);
                if (price < range || price == range)
                {
                    temp.Add(x);
                }
            }
            return temp;
        }
    }
}
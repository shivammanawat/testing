using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOD.DAL;
namespace MOD.BAL
{
    public class ProductBAL
    {
        public List<Product> GetAll()
        {
            using(CTSDBEntities db=new CTSDBEntities())
            {
                return db.Products.ToList();
            }
        }
        public Product Get(int id)
        {
            using (CTSDBEntities db = new CTSDBEntities())
            {
                return db.Products.Find(id);
            }
        }
        public void Add(Product item)
        {
            using (CTSDBEntities db = new CTSDBEntities())
            {
                db.Products.Add(item);
                db.SaveChanges();
            }
        }
    }
}

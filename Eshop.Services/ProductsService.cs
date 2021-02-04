using Eshop.Database;
using Eshop.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Services
{
    public class ProductsService
    {
        public void SaveProduct(Product product)
        {
            using(var context = new EshopDBContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void UpdateProduct(Product product)
        {
            using (var context = new EshopDBContext())
            {
                context.Entry(product).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public List<Product> GetProducts()
        {
            using (var context = new EshopDBContext())
            {
                return context.Products.ToList();
            }
        }

        public Product GetProduct(int id)
        {
            using (var context = new EshopDBContext())
            {
                return context.Products.Find(id);
            }
        }

        public void DeleteProduct(Product product)
        {
            using (var context = new EshopDBContext())
            {
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }
    }
}

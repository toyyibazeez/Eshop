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
    public class CategoriesService
    {
        public void SaveCategory(Category category)
        {
            using(var context = new EshopDBContext())
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }

        public void UpdateCategory(Category category)
        {
            using (var context = new EshopDBContext())
            {
                context.Entry(category).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public List<Category> GetCategories()
        {
            using (var context = new EshopDBContext())
            {
                return context.Categories.ToList();
            }
        }

        public Category GetCategory(int id)
        {
            using (var context = new EshopDBContext())
            {
                return context.Categories.Find(id);
            }
        }

        public void DeleteCategory(Category category)
        {
            using (var context = new EshopDBContext())
            {
                context.Categories.Remove(category);
                context.SaveChanges();
            }
        }
    }
}

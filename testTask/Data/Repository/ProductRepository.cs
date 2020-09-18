using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testTask.Data.interfaces;
using testTask.Data.Models;

namespace testTask.Data.Repository
{
    public class ProductRepository : IProducts
    {
        private readonly AppDBContent AppDBContent;

        // создаю ссылку на файл  AppDBContent чтобы работать с БД
        public ProductRepository(AppDBContent AppDBContent)
        {
            this.AppDBContent = AppDBContent;
        }

        // получаю продукты всех категорий
        public IEnumerable<Product> Products => AppDBContent.Product.Include(c => c.Category);

        // получаю продукты у которых available = true
        public IEnumerable<Product> getCategory => AppDBContent.Product.Where(p => p.available).Include(c => c.Category);

        public Product getObjectProduct(int product_id) // возвратит продукт по id
        {
            return AppDBContent.Product.FirstOrDefault(p => p.id == product_id);
        }

    }
}

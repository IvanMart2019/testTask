using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testTask.Data.interfaces;
using testTask.Data.Models;

namespace testTask.Data.Repository
{
    public class CategoryRepository : IProductsCategorys
    {
        private readonly AppDBContent AppDBContent;

        // создаю ссылку на файл  AppDBContent чтобы работать с БД
        public CategoryRepository(AppDBContent AppDBContent)
        {
            this.AppDBContent = AppDBContent;
        }

        public IEnumerable<Category> AllCategories => AppDBContent.Category;

    }
}

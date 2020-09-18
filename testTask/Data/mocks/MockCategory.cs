using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testTask.Data.interfaces;
using testTask.Data.Models;

namespace testTask.Data.mocks
{
    public class MockCategory : IProductsCategorys
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category
                    {
                        name = "Книги", description = "Покупайте книги лучших писателей."
                    },
                    new Category
                    {
                        name = "Курсы", description = "Покупайте Обучающие курсы."
                    }
                };
            }
        }
    }
}

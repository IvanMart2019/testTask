using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testTask.Data.interfaces;
using testTask.Data.Models;

namespace testTask.Data.mocks
{
    public class MockProduct : IProducts
    {
        private readonly IProductsCategorys _categoryProduct = new MockCategory();

        

        /* если будет появляться ошибка Серьезность	Код	Описание	
         * 
         * Строка	Состояние подавления
            Ошибка CS0535	
            "MockProduct" не реализует член интерфейса "IAllProducts.Products.set".	testTask D:\Work\testTask\testTask\Data\mocks\MockProduct.cs
        
            то зайдя в интерфейс удалить входной параметр set, оставить только get;
         */

        public IEnumerable<Product> Products
        {
            get {
                return new List<Product> {
                    new Product
                    {
                        name = "Преступление и наказание",
                        autor = "Фёдор Достоевский",
                        description = "Социально-психологический и социально-философский роман Фёдора Михайловича Достоевского",
                        data = "1866",
                        img = "https://interkniga.net/app/files/2019/01/978-5-389-02279-9.jpg",
                        available = true,
                        price = 1200,
                        byRalready_read = false,
                        Category = _categoryProduct.AllCategories.First()
                    },
                    new Product
                    {
                        name = "Гарри Поттер",
                        autor = "ДЖ.К РОУЛИНГ",
                        description = "Серия романов, написанная британской писательницей Дж. К. Роулинг. Книги представляют собой хронику приключений юного волшебника Гарри Поттера",
                        data = "1997",
                        img = "https://cdn1.regmarkets.ru/r1200/956b874ee7155c1ece47078c7d2eeb34.jpg",
                        available = true,
                        price = 3000,
                        byRalready_read = false,
                        Category = _categoryProduct.AllCategories.First()
                    },
                    new Product
                    {
                        name = "Fullstack JS",
                        autor = "THINK NETICA",
                        description = "Получите профессию Fullstack-разработчика со скидкой 40%. Курс английского в подарок. 18+ Научитесь верстать, программировать и создавать приложения на PHP",
                        data = "2019",
                        img = "https://1.bp.blogspot.com/-0kH0HKl_Hg4/XZGf01KzjaI/AAAAAAAAV3c/LxAPwukveBYiOJMJZA-CZLSzEZCRfzD6gCLcBGAsYHQ/s1600/Full-Stack-JavaScript.jpg",
                        available = true,
                        price = 12000,
                        byRalready_read = false,
                        Category = _categoryProduct.AllCategories.Last()
                    },
                };
            }
        }
        public IEnumerable<Product> getCategory { get; set; }

        public Product getObjectProduct(int product_id)
        {
            throw new NotImplementedException();
        }
    }
}

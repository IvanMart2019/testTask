using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testTask.Data.interfaces;
using testTask.ViewModels;

namespace testTask.Controllers
{
    public class ProductController : Controller
    {
        /*
         * Создаовая контроллер ProductController, представление я создовать буду с именем  Product. Т.е. просто  Product без приписывания Controller
            так система будет понимать, что  
            
        */
        private readonly IProducts _allProduct; // создаю переменную интерфейса IAllProducts и тепер могу образаться к методам этого интерфейса (_allProduct.Products)
        private readonly IProducts _allCategory;

        // 41

        public ProductController(IProducts iAllProducts, IProducts iProductCat)
        {
            //сделсь связываю класс интерфейса с моск классом который реализует методы этих интерфейсов в себе
            // сдесь я сделал привязку классов интерфейсов и классов которые их реализуют, 
            // теперь я могу передовать одни интерфейсы и вместе с ними будут передоваться все данные классов реализующих методы этих интерфейсов

            _allProduct = iAllProducts;
            _allCategory = iProductCat;
        }

        public ViewResult List()// реализует вывод продуктов
        {
            /*
             List выведет html страницу и передам _allProduct.Products в неё все продукты которые у меня есть.
             
             */
            var product = _allProduct.Products;
            ViewBag.Title = "Все инфо продукты ";
            ProductListViewModel productObject = new ProductListViewModel();
            productObject.AllProducts = _allProduct.Products;
            productObject.currentCategory = "Книги";

            return View(productObject);
        }
    }
}

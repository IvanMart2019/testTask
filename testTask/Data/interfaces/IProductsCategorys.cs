using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testTask.Data.Models;

namespace testTask.Data.interfaces
{
    public interface IProductsCategorys
    {
        // интерфейс отвечает за вывод всех категорий
        // хорошим тоном именования интерфейса являеться начало его названия с заглавной английской буквы ( I )
        // интерфейсы позволяют делать множественное наследование, в отличие от класса у которого в C# может быть один родитель.
        // Если класс наследует от интефейса, то все методы в интерфейсе должны быть описанны в классе иначе будет ошибка.

        IEnumerable<Category> AllCategories { get; }
      //  IEnumerable<Product> getPrice { get; }

        
    }
}

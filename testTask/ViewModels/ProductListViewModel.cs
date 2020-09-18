using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testTask.Data.Models;

namespace testTask.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> AllProducts { get; set; }

        public string currentCategory { get; set; }
    }
}

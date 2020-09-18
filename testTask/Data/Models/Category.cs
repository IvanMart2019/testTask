using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testTask.Data.Models
{
    public class Category
    {
        public int id { set; get; }

        public string name { set; get; }

        public string description { set; get; }

        public List<Product> Books { set; get; }
    }
}

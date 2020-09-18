using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testTask.Data.Models
{
    public class Product
    {
        public int id { set; get; }

        public string name { set; get; }

        public string description { set; get; }

        public string autor { set; get; }

        public bool available { set; get; }

        public string data { set; get; }

        public string img { set; get; }

        public double price { set; get; }

        public int category_id { set; get; }

        public bool byRalready_read { set; get; }

        public virtual Category Category { set; get; }
    }
}

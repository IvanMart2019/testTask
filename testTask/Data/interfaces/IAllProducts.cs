using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testTask.Data.Models;

namespace testTask.Data.interfaces
{
    public interface IProducts
    {
        IEnumerable<Product> Products { get; }

        IEnumerable<Product> getCategory { get; }

        Product getObjectProduct(int product_id);
    }
}

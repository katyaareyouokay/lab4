using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_responsibility_chain
{
    internal class ProductRequest
    {
        public string ProductName { get; }
        public ProductCategory Category { get; }

        public ProductRequest(string productName, ProductCategory category)
        {
            ProductName = productName;
            Category = category;
        }
    }
}

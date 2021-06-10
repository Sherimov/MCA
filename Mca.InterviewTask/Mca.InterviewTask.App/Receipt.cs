using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mca.InterviewTask.App
{
    public class Receipt
    {
        public IEnumerable<ProductList> ProductLists { get; set; }

        public Receipt(IEnumerable<ProductList> productLists)
        {
            ProductLists = productLists.OrderBy(productList => productList.Type);
        }

        public override string ToString()
        {
            var output = string.Empty;
            foreach (var productList in ProductLists)
            {
                output += productList.ToString();
            }
            foreach (var productList in ProductLists)
            {
                output += productList.GetTotalPrice() + Environment.NewLine;
            }
            foreach (var productList in ProductLists)
            {
                output += productList.GetTotalCount() + Environment.NewLine;
            }
            return output;
        }
    }
}

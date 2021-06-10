using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mca.InterviewTask.App
{
    public class ProductList
    {
        public IEnumerable<Product> Products { get; set; }

        public ProductListType Type { get; set; }

        public ProductList(IEnumerable<Product> products, ProductListType productListType)
        {
            Products = products.OrderBy(product => product.Name);
            Type = productListType;
        }

        public override string ToString()
        {
            var output = string.Empty;
            output += ". " + Type.ToString() + Environment.NewLine;
            foreach (var product in Products)
            {
                output += product.ToString() + Environment.NewLine;
            }
            return output;
        }

        public string GetTotalPrice()
        {
            return Type.ToString() + " cost: $" + string.Format("{0:0.0}", Products.Sum(product => product.Price));
        }

        public string GetTotalCount()
        {
            return Type.ToString() + " count: " + Products.Count();
        }
    }
    public enum ProductListType
    {
        Domestic, 
        Imported
    }
}

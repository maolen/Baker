using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class ConctereBuilder : IBuilder
    {
        private Product Product { get; set; } = new Product();
        public void AddPart(string part)
        {
            Product.Parts.Add(part);
        }

        public string GetProduct()
        {
            var product = new StringBuilder();
            product.AppendJoin('\t', Product.Parts);
            return product.ToString();
        }
    }
}

using System.Collections.Generic;

namespace TheShop.Api.Controllers
{
    public class Repository
    {
        private readonly List<Product> _products;

        public Repository()
        {
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
    }
}

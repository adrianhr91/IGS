using System.Collections.Generic;

namespace TheShop.Api.Controllers
{
    public class Repository
    {
        private readonly List<Product> _products;

        public Repository()
        {
            _products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Lavender heart",
                    Price = 9.25m
                },
                new Product
                {
                    Id = 2,
                    Name = "Personalised cufflinks",
                    Price = 45.00m
                },
                new Product
                {
                    Id = 3,
                    Name = "Kids T-shirt",
                    Price = 19.95m
                }
            };
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public List<Product> GetProducts()
        {
            return _products;
        }
    }
}

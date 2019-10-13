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
            product.Id = _products.Count + 1;
            _products.Add(product);
        }

        public List<Product> GetProducts()
        {
            return _products;
        }

        public Product GetProduct(int id)
        {
            var index = id - 1;

            return _products[index];
        }

        public void UpdateProduct(int id, Product newProduct)
        {
            var product = GetProduct(id);

            if (product != null)
            {
                product.Name = newProduct.Name;
            }
        }
    }
}

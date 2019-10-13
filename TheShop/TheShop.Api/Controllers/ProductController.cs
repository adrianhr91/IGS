using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TheShop.Api.Controllers
{
    [Route("v{version:apiVersion}")]
    [ApiController]
    [ApiVersion("1.0")]
    public class ProductController : ControllerBase
    {
        private Repository _repo;

        public ProductController(Repository repo)
        {
            _repo = repo;
        }

        [HttpGet("products")]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return _repo.GetProducts();
        }

        [HttpGet("product/{id}")]
        public ActionResult<Product> Get(int id)
        {
            var product = _repo.GetProduct(id);

            if (product != null)
            {
                return product;
            }

            return NotFound();
        }

        [HttpPost("product")]
        public void Post([FromForm] Product product)
        {
            _repo.AddProduct(product);
        }

        [HttpPut("product/{id}")]
        public void Put(int id, [FromForm] Product product)
        {

        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

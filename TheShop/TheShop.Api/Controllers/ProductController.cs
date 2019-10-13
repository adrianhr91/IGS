using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TheShop.Api.Controllers
{
    [Route("v{version:apiVersion}")]
    [ApiController]
    [ApiVersion("1.0")]
    [NotFoundFilter]
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
            return _repo.GetProduct(id);
        }

        [HttpPost("product")]
        public void Post([FromForm] Product product)
        {
            _repo.AddProduct(product);
        }

        [HttpPut("product/{id}")]
        public void Put(int id, [FromForm] Product product)
        {
            _repo.UpdateProduct(id, product);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

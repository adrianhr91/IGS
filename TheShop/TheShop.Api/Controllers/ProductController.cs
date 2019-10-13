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

        // GET api/products
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" }
            ;
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        [HttpPost("product")]
        public void Post([FromForm] Product product)
        {
            _repo.AddProduct(product);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

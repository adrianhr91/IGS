using Newtonsoft.Json;

namespace TheShop.Api.Controllers
{
    public class Product
    {
        public int? Id { get; set; }
        public string Name { get; set; }

        [JsonConverter(typeof(PriceTypeConverter))]
        public decimal Price { get; set; }
    }

    public class ProductDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
    }
}

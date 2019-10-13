using Newtonsoft.Json;

namespace TheShop.Api.Product
{
    public class Product
    {
        public int? Id { get; set; }
        public string Name { get; set; }

        [JsonConverter(typeof(PriceTypeConverter))]
        public decimal Price { get; set; }
    }
}

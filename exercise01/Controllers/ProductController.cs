using Microsoft.AspNetCore.Mvc;

namespace exercise01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public Products[] Products  { get; set;}

        // GET: api/Product
        [HttpGet]
        public ActionResult<IEnumerable<Products>> GetAllProduct()
        {

            var orders = new List<Products>
            {
                new Products { Name="sdfghjk", Id="5" },
                new Products { Name="sara", Id="326206984" }
            };
            return Ok(orders);
        }
        // GET: api/Product/{id}
        [HttpGet("{id}")]
        public ActionResult<Products> GetProductId(string id)
        {
            var product = new Products
            {
                Id = id,
                Name = $"product {id}"
            };
            return Ok(product);
        }

        // POST: api/Product
        [HttpPost]
        public void CreateOrder([FromBody] Products Product)
        {
            // Logic to create order
        }

        // PUT: api/Product/1
        [HttpPut("{id}")]
        public void UpdateOrder( string id, [FromBody] Products Product)
        {
            Product.Id = id;
            // Logic to update order
        }
    }
}
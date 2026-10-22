using Api_Verging_Task.DTOs;
using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Api_Verging_Task.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/products")]
    public class ProductsV1Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var products = new List<ProductV1Dto>
            {
                new() { Id = 1, Name = "Laptop", Price = 25000 }
            };
            return Ok(products);
        }
    }
}
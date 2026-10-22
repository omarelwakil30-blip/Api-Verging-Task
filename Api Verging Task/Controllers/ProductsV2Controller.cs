using Api_Verging_Task.DTOs;
using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Api_Verging_Task.Controllers
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/products")]
    public class ProductsV2Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var products = new List<ProductV2Dto>
            {
                new() { Id = 1, Name = "Laptop", Price = 25000, CategoryName = "Electronics" }
            };
            return Ok(products);
        }
    }
}
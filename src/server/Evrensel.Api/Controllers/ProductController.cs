using Evrensel.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Evrensel.Api.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet()]
        public IActionResult GetAll() => Ok("All product.");

        [HttpGet("{id}")]
        public IActionResult Get(int id) => Ok("One product.");

        [HttpPost]
        public IActionResult Add([FromBody] Product model) => Ok("Product is added.");

        [HttpPut]
        public IActionResult Update([FromBody] Product model) => Ok("Product is updated.");
        
        [HttpDelete]
        public IActionResult Delete(int id) => Ok("Product is deleted.");

    }
}

using Microsoft.AspNetCore.Mvc;

namespace FTELMarket.Api.Controllers;

[ApiController, Route("api/[controller]s")]
public class ProductController : ControllerBase
{

    [HttpGet]
    public IActionResult Get([FromQuery] int page = 1, [FromQuery] int pageSize = 25)
    {
        var mocker = new Mocker();
        var products = mocker.GetMockProducts();
        return Ok(products);
    }

    [HttpPost]
    public IActionResult Post([FromBody] ProductCreationDto productDto)
    {
        // validation
        if (productDto.IsValid())
        {
            var product = productDto.ToProduct();
            // Here you would typically save the product to a database or perform other business logic.
            return Ok(product);
        }

        return BadRequest(new { message = "Invalid product data." });
    }


}

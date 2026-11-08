using FTELMarket.Api.Extensions;
using FTELMarket.Api.Models;
using FTELMarket.Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FTELMarket.Api.Controllers;

[ApiController, Route("api/[controller]s")]
public class ProductController : ControllerBase
{

    private readonly IRepository<Product> _productsRepository;

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] int page = 1, [FromQuery] int pageSize = 25)
    {
        
        var products =  await _productsRepository.GetAllAsync();
        return Ok(products);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] ProductCreationDto productDto)
    {
        // validation
        if (productDto.IsValid())
        {
            var product = productDto.ToProduct();
            // Here you would typically save the product to a database or perform other business logic.
            await _productsRepository.AddAsync(product);
            return Ok(product);
        }

        return BadRequest(new { message = "Invalid product data." });
    }


}

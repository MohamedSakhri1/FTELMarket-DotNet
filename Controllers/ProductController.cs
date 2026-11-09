using System;
using FTELMarket.Api.DTOs.Product;
using FTELMarket.Api.Extensions;
using FTELMarket.Api.Models;
using FTELMarket.Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FTELMarket.Api.Controllers;

[ApiController, Route("api/[controller]s")]
public class ProductController : ControllerBase
{

    private readonly IRepository<Product> _productService;
    private readonly IRepository<Category> _categoryService;

    public ProductController(IRepository<Product> productsRepository, IRepository<Category> categoryService)
    {
        _productService = productsRepository;
        _categoryService = categoryService;
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] int page = 1, [FromQuery] int pageSize = 25)
    {
        
        var products =  await _productService.GetAllAsync();
        return Ok(products);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] ProductCreationDto productDto)
    {

        if (productDto.IsValid())
        {

            var category = await _categoryService.GetByIdAsync(productDto.CategoryId);
            if (category == null) return NotFound(new { message = "Category not found." });

            var product = productDto.ToProduct();
            product.CategoryName = category?.Name;

            await _productService.AddAsync(product);
            return Ok(product);
        }

        return BadRequest(new { message = "Invalid product data." });
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] ProductCreationDto productDto)
    {
        if (productDto.IsValid())
        {
            var existingProduct = await _productService.GetByIdAsync(id);
            var category = await _categoryService.GetByIdAsync(productDto.CategoryId);

            if (existingProduct == null || category == null) return NotFound(new { message = "Product or Category not found." });

            existingProduct.UpdateFieldsFrom(productDto);
            existingProduct.CategoryName = category?.Name;

            await _productService.UpdateAsync(existingProduct);
            return Ok(existingProduct);
        }

        return BadRequest(new { message = "Invalid product data." });
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var existingProduct = await _productService.GetByIdAsync(id);
        if (existingProduct == null) return NotFound(new { message = "Product not found." });

        await _productService.DeleteAsync(id);
        return NoContent();
    }


}

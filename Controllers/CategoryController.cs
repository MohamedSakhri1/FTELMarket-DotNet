
using FTELMarket.Api.Models;
using FTELMarket.Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FTELMarket.Api.Controllers;

[ApiController, Route("api/categories")]
public class CategoryController : ControllerBase
{

    private readonly IRepository<Category> _categoryService;

    public CategoryController(IRepository<Category> categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
        var categories = await _categoryService.GetAllAsync();
        return Ok(categories);
    }
    
}

using Microsoft.AspNetCore.Mvc;

[ApiController, Route("api/categories")]
public class CategoryController : ControllerBase
{

    [HttpGet]
    public IActionResult Get()
    {
        var mocker = new Mocker();
        var categories = mocker.GetMockCategories();
        return Ok(categories);
    }
}
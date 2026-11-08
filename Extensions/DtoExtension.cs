using FTELMarket.Api.Models;

namespace FTELMarket.Api.Extensions;

public static class DtoExtension
{
    public static Product ToProduct(this ProductCreationDto dto)
    {
        var mocker = new Mocker();
        var categoryName = mocker.GetMockCategories().FirstOrDefault(cat => cat.Id == dto.CategoryId)?.Name ?? "dont exist";


        return new Product
        {
            Name = dto.Name,
            Description = dto.Description,
            Price = dto.Price,
            Stock = dto.Stock,
            CategoryId = dto.CategoryId,
            CreatedAt = DateTime.Now,
            CategoryName = categoryName
        };
    }
}
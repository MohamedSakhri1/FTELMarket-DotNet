using FTELMarket.Api.DTOs.Product;
using FTELMarket.Api.Models;

namespace FTELMarket.Api.Extensions;

public static class DtoExtension
{
    public static Product ToProduct(this ProductCreationDto dto)
    {

        return new Product
        {
            Name = dto.Name,
            Description = dto.Description,
            Price = dto.Price,
            Stock = dto.Stock,
            CategoryId = dto.CategoryId
        };
    }

    public static void UpdateFieldsFrom(this Product product, ProductCreationDto dto)
    {
        product.Name = dto.Name;
        product.Description = dto.Description;
        product.Price = dto.Price;
        product.Stock = dto.Stock;
        product.CategoryId = dto.CategoryId;
    }
}
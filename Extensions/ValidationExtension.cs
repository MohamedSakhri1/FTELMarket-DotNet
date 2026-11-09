

using FTELMarket.Api.DTOs.Product;

namespace FTELMarket.Api.Extensions;

public static class ValidationExtension
{
    public static bool IsValid(this ProductCreationDto dto)
    {
        if (1 > dto.Name.Length || dto.Name.Length > 200) return false;
        if (dto.Description != null && dto.Description.Length > 1000) return false;
        if (dto.Price < 0.01 || dto.Price > 1000000) return false;
        if (dto.Stock < 0) return false;
        if (dto.CategoryId < 1) return false;

        return true;
    }
}
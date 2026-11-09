
using System.ComponentModel.DataAnnotations;

namespace FTELMarket.Api.DTOs.Product;

public record ProductCreationDto(

    [Required] string Name,
    string? Description,
    [Required] double Price,
    [Required] int Stock,
    [Required] int CategoryId
);


/* {
    "name": "The Last of Us Part II",
  "description": "Boîte et notice, disque sans rayure.",
  "price": 19.9, (<10000 et >0.0.1)
  "stock": 3,
  "categoryId": 1
} 
*/
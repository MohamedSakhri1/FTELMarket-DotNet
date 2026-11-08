
using FTELMarket.Api.Models;
namespace FTELMarket.Api.Models;

public class Category : IEntity
{
    public  int Id { get; set; }
    public string? Name { get; set; }
}
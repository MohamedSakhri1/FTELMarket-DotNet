

public class Product
{

    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
    public int CategoryId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public string? CategoryName { get; set; }

}

/* {
    "id": 1,
    "name": "The Last of Us Part II",
    "description": "Boîte et notice, disque sans rayure.",
    "price": 19.9,
    "stock": 3,
    "categoryId": 1,
    "createdAt": "2026-09-02T09:15:00Z",
    "categoryName": "PlayStation 5"
  } 
  */
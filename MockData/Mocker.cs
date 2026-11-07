public class Mocker
{

    public List<Product> GetMockProducts()
    {
        return new List<Product> {
            new Product { Id = 1, Name = "The Last of Us Part II", Description = "Boîte et notice, disque sans rayure.", Price = 19.9, Stock = 3, CategoryId = 1, CreatedAt = new DateTime(2026, 9, 2, 9, 15, 0), CategoryName = "PlayStation 5" },
            new Product { Id = 2, Name = "Gran Turismo 7", Description = null, Price = 29.9, Stock = 1, CategoryId = 1, CreatedAt = new DateTime(2026, 9, 5, 14, 30, 0), CategoryName = "PlayStation 5" },
            new Product { Id = 3, Name = "The Legend of Zelda: Tears of the Kingdom", Description = "Cartouche seule.", Price = 39.9, Stock = 2, CategoryId = 2, CreatedAt = new DateTime(2026, 9, 8, 10, 0, 0), CategoryName = "Nintendo Switch" },
            new Product { Id = 4, Name = "Mario Kart 8 Deluxe", Description = "Complet, très bon état.", Price = 34.9, Stock = 5, CategoryId = 2, CreatedAt = new DateTime(2026, 9, 10, 16, 45, 0), CategoryName = "Nintendo Switch" },
            new Product { Id = 5, Name = "Halo Infinite", Description = null, Price = 14.9, Stock = 4, CategoryId = 3, CreatedAt = new DateTime(2026, 9, 12, 11, 20, 0), CategoryName = "Xbox Series X" },
            new Product { Id = 6, Name = "Forza Horizon 5", Description = "Édition standard.", Price = 24.9, Stock = 0, CategoryId = 3, CreatedAt = new DateTime(2026, 9, 15, 8, 5, 0), CategoryName = "Xbox Series X" },
            new Product { Id = 7, Name = "Baldur’s Gate 3", Description = "Clé physique, coffret collector.", Price = 44.9, Stock = 1, CategoryId = 4, CreatedAt = new DateTime(2026, 9, 18, 17, 40, 0), CategoryName = "PC" },
            new Product { Id = 8, Name = "Hades", Description = null, Price = 9.9, Stock = 6, CategoryId = 4, CreatedAt = new DateTime(2026, 9, 21, 13, 10, 0), CategoryName = "PC" }
        };
    }

    public List<Category> GetMockCategories()
    {
        return new List<Category> {
            new Category { Id = 1, Name = "PlayStation 51" },
            new Category { Id = 2, Name = "Nintendo Switch" },
            new Category { Id = 3, Name = "Xbox Series X" },
            new Category { Id = 4, Name = "PC" }
        };
    }
}

/*
[
  {
    "id": 1,
    "name": "PlayStation 5"
  },
  {
    "id": 2,
    "name": "Nintendo Switch"
  },
  {
    "id": 3,
    "name": "Xbox Series X"
  },
  {
    "id": 4,
    "name": "PC"
  }
]
*/
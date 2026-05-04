using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Entities;

public class Product
{
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    public required string Name { get; set; } 

    [Range(0.01, 100000)]
    public decimal Price { get; set; }

    public int StockQuantity { get; set; }
}
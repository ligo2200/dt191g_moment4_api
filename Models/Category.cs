using System.ComponentModel.DataAnnotations;

namespace moment4_api.Models;

public class Category {
    public int CategoryId { get; set; }

    [Required]
    public string? CategoryName { get; set; } 
    
} 
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace moment4_api.Models;

public class Song {
    public int SongId { get; set; }
    [Required]
    public string? Artist { get; set; }
    [Required]
    public string? SongTitle { get; set; }
    public int? Length { get; set; }
    public int CategoryId { get; set; }

    
    public Category? Category { get; set; }
} 
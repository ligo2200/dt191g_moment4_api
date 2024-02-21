using System.ComponentModel.DataAnnotations;

namespace moment4_api.Models;

public class Song {
    public int SongId { get; set; }
    [Required]
    public string? Artist { get; set; }
    [Required]
    public string? SongTitle { get; set; }
    public int? Length { get; set; }
    public string? Category { get; set; }
} 
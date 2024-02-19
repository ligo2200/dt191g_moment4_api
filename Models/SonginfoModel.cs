namespace moment4_api.Models;

public class Song {
    public int SongId { get; set; }
    public string? Artist { get; set; }
    public string? SongTitle { get; set; }
    public int? Length { get; set; }
    public string? Category { get; set; }
} 
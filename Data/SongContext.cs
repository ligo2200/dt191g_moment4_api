using moment4_api.Models;
using Microsoft.EntityFrameworkCore;

namespace moment4_api.Data;

public class SongContext : DbContext
{
    public SongContext(DbContextOptions<SongContext> options) : base(options)
    {

    }

    public DbSet<Song> Songs { get; set; } 
}
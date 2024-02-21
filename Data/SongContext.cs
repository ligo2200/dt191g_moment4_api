using Moment4_api.Models;
using Microsoft.EntityFrameworkCore;

namespace Moment4_api.Data;

public class SongContext : DbContext
{
    public SongContext(DbContextOptions<SongContext> options) : base(options)
    {

    }

    public DbSet<Song> Songs { get; set; } = null!;
}
using moment4_api.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace moment4_api.Data;

public class SongContext : DbContext
{
    public SongContext(DbContextOptions<SongContext> options) : base(options)
    {

    }

    public DbSet<Song> Songs { get; set; } 
    public DbSet<Category> Categories { get; set; } 

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Song>()
                .HasOne(song => song.Category)
                .WithMany()
                .HasForeignKey(song => song.CategoryId)
                .IsRequired();
        }
}
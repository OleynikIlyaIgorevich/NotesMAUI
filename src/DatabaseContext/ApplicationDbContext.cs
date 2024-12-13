using Microsoft.EntityFrameworkCore;
using NotesMAUI.Entities;

namespace NotesMAUI.DatabaseContext;

public class ApplicationDbContext : DbContext
{
    public DbSet<UserEntity> Users { get; set; } = null!;
    public DbSet<NoteEntity> Notes { get; set; } = null!;
    public DbSet<CategoryEntity> Categories { get; set; } = null!;

    public ApplicationDbContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserEntity>(x =>
        {
            x.HasKey(u => u.Id);

            x.HasIndex(x => x.Username).IsUnique();
        });


        modelBuilder.Entity<NoteEntity>(x => 
        {
            x.HasKey(n => n.Id);

            x.HasIndex(x => x.Title).IsUnique();

            x.HasOne(n => n.User).WithMany(u => u.Notes).HasForeignKey(u => u.UserId);
            x.HasOne(n => n.Category).WithMany(c => c.Notes).HasForeignKey(n => n.CategoryId);
        });

        modelBuilder.Entity<CategoryEntity>(x =>
        {
            x.HasKey(c => c.Id);

            x.HasIndex(c => c.Title).IsUnique();
        });
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var dbPath = Path.Combine(FileSystem.Current.AppDataDirectory, "NotesDb.db");
        optionsBuilder.UseSqlite($"Filename={dbPath}");
    }
}

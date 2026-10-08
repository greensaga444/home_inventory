using HomeVault.Domain;
using Microsoft.EntityFrameworkCore;

namespace HomeVault.Data;

public sealed class HomeVaultDbContext : DbContext
{
    public HomeVaultDbContext(DbContextOptions<HomeVaultDbContext> options)
        : base(options)
    {
    }

    public DbSet<Asset> Assets => Set<Asset>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Asset>(builder =>
        {
            builder.HasKey(asset => asset.Id);
            builder.Property(asset => asset.Name).IsRequired();
            builder.Property(asset => asset.Category).HasMaxLength(100);
            builder.Property(asset => asset.Location).HasMaxLength(100);
        });
    }
}

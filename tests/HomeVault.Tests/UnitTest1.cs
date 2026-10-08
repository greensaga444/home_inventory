using HomeVault.Data;
using HomeVault.Domain;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace HomeVault.Tests;

public class AssetPersistenceTests
{
    [Fact]
    public async Task AcFr001_SaveValidAsset_PersistsAndReturnsInInventoryList()
    {
        await using var db = CreateSqliteContext();

        var asset = new Asset
        {
            Name = "Coffee Machine",
            Category = "Kitchen",
            Location = "Kitchen Counter"
        };

        db.Assets.Add(asset);
        await db.SaveChangesAsync();

        var inventory = await db.Assets.AsNoTracking().ToListAsync();

        Assert.Single(inventory);
        Assert.Contains(inventory, a => a.Name == "Coffee Machine");
    }

    [Fact]
    public async Task AcFr001_SaveAssetWithoutRequiredName_ThrowsAndDoesNotPersist()
    {
        await using var db = CreateSqliteContext();

        db.Assets.Add(new Asset
        {
            Name = null!,
            Category = "Kitchen",
            Location = "Shelf"
        });

        await Assert.ThrowsAsync<DbUpdateException>(() => db.SaveChangesAsync());

        var inventory = await db.Assets.AsNoTracking().ToListAsync();
        Assert.Empty(inventory);
    }

    [Fact]
    public async Task AcFr001_SaveAssetWithOneCharacterName_PersistsSuccessfully()
    {
        await using var db = CreateSqliteContext();

        db.Assets.Add(new Asset
        {
            Name = "A",
            Category = "Electronics",
            Location = "Desk"
        });

        await db.SaveChangesAsync();

        var inventory = await db.Assets.AsNoTracking().ToListAsync();
        Assert.Single(inventory);
        Assert.Equal("A", inventory[0].Name);
    }

    private static HomeVaultDbContext CreateSqliteContext()
    {
        var connection = new SqliteConnection("Data Source=:memory:");
        connection.Open();

        var options = new DbContextOptionsBuilder<HomeVaultDbContext>()
            .UseSqlite(connection)
            .Options;

        var db = new HomeVaultDbContext(options);
        db.Database.EnsureCreated();
        return db;
    }
}

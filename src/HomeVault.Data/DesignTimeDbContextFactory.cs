using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace HomeVault.Data;

public sealed class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<HomeVaultDbContext>
{
    public HomeVaultDbContext CreateDbContext(string[] args)
    {
        var options = new DbContextOptionsBuilder<HomeVaultDbContext>()
            .UseSqlite("Data Source=homevault.db")
            .Options;

        return new HomeVaultDbContext(options);
    }
}

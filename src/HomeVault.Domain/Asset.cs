namespace HomeVault.Domain;

public sealed class Asset
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string? Category { get; set; }

    public string? Location { get; set; }

    public bool IsArchived { get; set; }
}

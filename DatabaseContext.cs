using Microsoft.EntityFrameworkCore;

namespace hc_6589;

public class DatabaseContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Test> Tests { get; set; } = null!;

    public DbSet<TestNumber> TestNumbers { get; set; } = null!;

    public DbSet<TestText> TestTexts { get; set; } = null!;
}

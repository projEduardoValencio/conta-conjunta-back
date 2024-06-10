
using Microsoft.EntityFrameworkCore;

public class ConjuntaDbSqliteContext : DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }
    public string DbPath { get; }

    public ConjuntaDbSqliteContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        string path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "conjunta.db");

        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={DbPath}");
    }
}
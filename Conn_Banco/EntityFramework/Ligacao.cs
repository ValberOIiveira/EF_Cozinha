using Microsoft.EntityFrameworkCore;

namespace exemplo1.EntityFramework;

public class Ligacao : DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql
        (
            "Host=localhost;" +
            "Database=Aula1;" +
            "Username=postgres;" +
            "Password=root");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>().ToTable("usuario");
    }
}
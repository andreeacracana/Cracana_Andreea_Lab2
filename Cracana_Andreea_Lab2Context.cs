using Microsoft.EntityFrameworkCore;

public class Cracana_Andreea_Lab2Context(DbContextOptions<Cracana_Andreea_Lab2Context> options) : DbContext(options)
{
    public DbSet<Cracana_Andreea_Lab2.Models.Book> Book { get; set; } = default!;
    public DbSet<Cracana_Andreea_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    public DbSet<Cracana_Andreea_Lab2.Models.Author> Author { get; set; } = default!;

}

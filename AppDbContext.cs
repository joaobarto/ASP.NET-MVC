using Microsoft.EntityFrameworkCore;
using MinhaAppMvc.Models;

public class AppDbContext : DbContext
{
public AppDbContext(DbContextOptions<AppDbContext> options)
: base(options)
{
}
//DbSets personalizados, se quiser adicionar depois
public DbSet<Tarefa> Tarefas { get; set; }
}
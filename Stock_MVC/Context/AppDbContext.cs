using Microsoft.EntityFrameworkCore;
using Stock_MVC.Models;

namespace Stock_MVC.Context {
    public class AppDbContext : DbContext{

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
        }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }

    }
}

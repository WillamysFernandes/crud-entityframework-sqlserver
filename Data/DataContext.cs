using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    
    public class DataContext : DbContext //Aqui é especifica quem você que seja usado no banco
    {
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Data Source=DESKTOP-8U0OIEV\\SQLEXPRESS1;Initial Catalog=projetinho;Integrated Security=True;TrustServerCertificate=True");
    }
}
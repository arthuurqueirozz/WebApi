using Microsoft.EntityFrameworkCore;
using WebApi8_Video.Models;

namespace WebApi8_Video.Data
{
    public class AppDBContext : DbContext
    {
        
        public AppDBContext(DbContextOptions<AppDBContext> options) : base (options) 
        {
        }


        public DbSet<AutorModel> Autores { get; set; }
        public DbSet<BookModel> Livros{ get; set; }

    }
}

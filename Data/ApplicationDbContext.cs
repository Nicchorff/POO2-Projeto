using Microsoft.EntityFrameworkCore;
using POO2_Projeto.Models;

namespace POO2_Projeto.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<ABO> ABOs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().HasKey(m => m.Cpf);
            base.OnModelCreating(builder);
        }
    }
}

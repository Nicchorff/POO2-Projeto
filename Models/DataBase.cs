using Microsoft.EntityFrameworkCore;

namespace POO2_Projeto.Models
{
    public class DataBase : DbContext 
    { protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        { 
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=POO2-Projeto;Integrade Security=True;"); 
        } 
    }
}

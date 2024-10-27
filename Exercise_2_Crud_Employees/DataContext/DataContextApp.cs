using Exercise_2_Crud_Employees.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercise_2_Crud_Employees.DataContext
{
    public class DataContextApp(DbContextOptions opciones) : DbContext(opciones)
    {
        public DbSet<Employees> employees { get; set; }
    }
}
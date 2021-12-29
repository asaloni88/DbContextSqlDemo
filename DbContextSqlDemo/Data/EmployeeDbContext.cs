using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbContextSqlDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace DbContextSqlDemo.Data
{
    internal class EmployeeDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(LocalDB)\\MSSQLLocalDB;Database=EmployeeDB;Trusted_Connection=True");
        }
        public DbSet<Employee> Employees { get; set; }   
    }
}

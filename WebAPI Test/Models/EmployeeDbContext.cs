using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAPI_Test.Models
{
    public class EmployeeDbContext : DbContext
    {
      public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options): base(options)
        { }

        public DbSet<Employee> Employee { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-SE277G7\\RAJEEVSQLSERVER;Initial Catalog=Employees;Persist Security Info=True;User ID=sa;Password=Rajeevp727;");
        }


    }
}

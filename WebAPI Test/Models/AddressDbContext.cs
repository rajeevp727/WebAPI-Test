using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Test.Models
{
    public class AddressDbContext : DbContext
    {
        public AddressDbContext(DbContextOptions<AddressDbContext> options): base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Address> Address { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-SE277G7\\RAJEEVSQLSERVER;Initial Catalog=Employees;Persist Security Info=True;User ID=sa;Password=Rajeevp727;");
        }
    }
}

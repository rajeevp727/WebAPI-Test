using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Test.Models
{
    public class ContactDbContext : DbContext
    {
        public ContactDbContext(DbContextOptions<ContactDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Contact> Contact { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-SE277G7\\RAJEEVSQLSERVER;Initial Catalog=Employees;Persist Security Info=True;User ID=sa;Password=Rajeevp727;");
        }
    }
}

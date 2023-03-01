using Labb3Databas.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3Databas.Data
{
    public class DatabaseDBContext : DbContext
    {

        public DbSet<Betyg> Betygs { get; set; }
        public DbSet<Klass> Klasses { get; set; }
        public DbSet<Kurs> Kurses { get; set; }
        public DbSet<Personal> Personals { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = LAPTOP-GV0D7VCD;Initial Catalog=SchoolDBFirst;Integrated Security = True;TrustServerCertificate=True;");
        }
    }
}
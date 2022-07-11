using System;
using System.Collections.Generic;
using System.Linq;
using finalhazirlik.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace finalhazirlik.Models.Context
{
    public class OgrenciContext: DbContext
    {
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=OkulDb1;Integrated Security=true");
        }
    }
}

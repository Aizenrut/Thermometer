using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Core.DbContexts
{
    public class ThermometerContext : DbContext
    {
        public DbSet<Data> Datas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(GlobalVars.ConnectionString);
        }
    }
}

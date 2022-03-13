using inventarioSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace inventarioSystem.Context
{
    public class InventarioContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            optionBuilder.UseMySql(configuration["connectionString:ProductionDb"]);
        }

        public virtual DbSet<Categoria> categoria { get; set; }
    }
}

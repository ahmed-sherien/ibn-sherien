using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using AhmedSherien.Domain.Companies;
using Microsoft.Extensions.Configuration;
using AhmedSherien.Domain.Common;
using AhmedSherien.Persistence.Companies;

namespace AhmedSherien.Persistence.Shared
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        public DbSet<Company> Companies { get; set; }

        public new DbSet<T> Set<T>() where T : class, IEntity
        {
            return base.Set<T>();
        }

        public void Save()
        {
            this.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new CompaniesConfiguration(modelBuilder.Entity<Company>());
        }
    }
}

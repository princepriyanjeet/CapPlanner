using Domain.BusinessUnits;
using Domain.Comon;
using Domain.Trackers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Peristence.Shared
{
    public class CapacityPlannerDbContext:DbContext, IDatabaseContext
    {
        public CapacityPlannerDbContext(DbContextOptions<CapacityPlannerDbContext> options):base(options)
        {

        }

        public DbSet<Tracker> Trackers { get; set; }
        public DbSet<BusinessUnit> BusinessUnits { get; set; }
        public new DbSet<T> Set<T>() where T : class, IEntity
        {
            return base.Set<T>();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public void Save()
        {
            this.SaveChanges();
        }
    }
}

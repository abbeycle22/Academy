using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CarInsuranceCFEF.DAL
{
    public class DriverContext : DbContext
    {
        public DriverContext() : base ("DriverContext")
        {

        }
        public DbSet<Models.Driver> Drivers { get; set; }
        public DbSet<Models.Car> Cars { get; set; }
        public DbSet<Models.DrivingRecord> DrivingRecords { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
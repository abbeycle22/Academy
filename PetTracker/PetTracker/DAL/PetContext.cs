using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetTracker.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PetTracker.DAL
{
    public class PetContext : DbContext
    {
        public PetContext() : base("PetContext")
        {
        }

        public DbSet<Pet> Pets { get; set; }
        public DbSet<Owner> Owners { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
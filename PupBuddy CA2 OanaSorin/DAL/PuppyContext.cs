using PupBuddy_CA2_OanaSorin.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace PupBuddy_CA2_OanaSorin.DAL
{
    public class PuppyContext : DbContext
    {
        public PuppyContext() : base("PuppyContext")
        {
        }

        public DbSet<PuppyModel> Puppy { get; set; }
        public DbSet<OwnerModel> PuppyOwner { get; set; }
        public DbSet<MeetingModel> Meetings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}
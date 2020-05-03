using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PupBuddy_CA2_OanaSorin.Models
{
    public class ModelContext : DbContext
    {
        public ModelContext()
            : base("name=ModelContext")
        { }

        public virtual DbSet<PuppyModel> Puppy { get; set; }

    }
}
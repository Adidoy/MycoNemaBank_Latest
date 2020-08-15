using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MycoNema_Bank.Models
{
    public class MycoNemaContext : DbContext
    {
        public MycoNemaContext() : base("MycoNemaContext") { }

        public DbSet<TaxonomicClasses> TaxonomicClass { get; set; }
        public DbSet<TaxonomicUnit> TaxonomicUnits { get; set; }
        public DbSet<Publications> Publications { get; set; }
        public DbSet<TaxonPublication> TaxonPublication { get; set; }
        public DbSet<Provinces> Provinces { get; set; }
        public DbSet<Municipalities> Municipalities { get; set; }
        public DbSet<Locations> Locations { get; set; }
        public DbSet<Hosts> Hosts { get; set; }
        public DbSet<SpeciePerLocationAndHost> SpeciePerLocationAndHost { get; set; }
        public DbSet<Characteristics> Characteristics { get; set; }
        public DbSet<Citation> Citations { get; set; }
    }
}
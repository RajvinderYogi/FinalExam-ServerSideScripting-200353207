namespace COMP2084FinalF2017.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OlympicModel : DbContext
    {
        public OlympicModel()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
                .Property(e => e.Country1)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.Flag)
                .IsUnicode(false);
        }
    }
}

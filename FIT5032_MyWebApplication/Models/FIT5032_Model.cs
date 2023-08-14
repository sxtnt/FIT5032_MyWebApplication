using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FIT5032_MyWebApplication.Models
{
    public partial class FIT5032_Model : DbContext
    {
        public FIT5032_Model()
            : base("name=FIT5032_Model")
        {
        }

        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Unit> Units { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>()
                .HasMany(e => e.Units)
                .WithRequired(e => e.Patient)
                .WillCascadeOnDelete(false);
        }
    }
}

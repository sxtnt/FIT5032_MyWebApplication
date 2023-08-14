using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FIT5032_MyWebApplication.Models
{
    public partial class FIT5032_Appointment_Model : DbContext
    {
        public FIT5032_Appointment_Model()
            : base("name=FIT5032_Appointment_Model")
        {
        }

        public virtual DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

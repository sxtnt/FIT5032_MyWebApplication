namespace FIT5032_MyWebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Appointment
    {
        public int Id { get; set; }

        public int DoctorID { get; set; }

        public int PatientID { get; set; }

        [Required]
        public string Date { get; set; }
    }
}

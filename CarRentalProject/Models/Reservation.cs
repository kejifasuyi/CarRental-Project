namespace CarRentalProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Reservation")]
    public partial class Reservation
    {
        [Key]
        [StringLength(50)]
        public string resID { get; set; }

        [StringLength(50)]
        public string userID { get; set; }

        [StringLength(50)]
        public string carID { get; set; }

        public DateTime? fromDate { get; set; }

        public DateTime? toDate { get; set; }

        public virtual Car Car { get; set; }

        public virtual UserAccount UserAccount { get; set; }
    }
}

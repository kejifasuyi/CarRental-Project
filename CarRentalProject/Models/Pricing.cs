namespace CarRentalProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pricing")]
    public partial class Pricing
    {
        [StringLength(50)]
        public string pricingID { get; set; }

        [StringLength(50)]
        public string carID { get; set; }

        public decimal? rate { get; set; }

        public virtual Car Car { get; set; }
    }
}

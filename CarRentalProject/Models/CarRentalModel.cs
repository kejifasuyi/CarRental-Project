namespace CarRentalProject
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CarRentalModel : DbContext
    {
        public CarRentalModel()
            : base("name=CarRentalModel")
        {
        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Pricing> Pricings { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<UserAccount> UserAccounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

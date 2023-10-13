using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace HospitalSystem
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=SqlConnection")
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<MedicalField> MedicalFields { get; set; }
        public virtual DbSet<PaymentDetail> PaymentDetails { get; set; }
        public virtual DbSet<ProvidedService> ProvidedServices { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<DetailsOfProvidedService> DetailsOfProvidedServices { get; set; }
        public virtual DbSet<RegularCustomer> RegularCustomers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasMany(e => e.PaymentDetails)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Doctor>()
                .HasMany(e => e.ProvidedServices)
                .WithRequired(e => e.Doctor1)
                .HasForeignKey(e => e.Doctor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MedicalField>()
                .HasMany(e => e.Services)
                .WithRequired(e => e.MedicalField1)
                .HasForeignKey(e => e.MedicalField)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PaymentDetail>()
                .Property(e => e.FinalPrice)
                .HasPrecision(15, 3);

            modelBuilder.Entity<ProvidedService>()
                .HasMany(e => e.PaymentDetails)
                .WithRequired(e => e.ProvidedService)
                .HasForeignKey(e => e.IdProvidedServices);

            modelBuilder.Entity<Service>()
                .HasMany(e => e.ProvidedServices)
                .WithRequired(e => e.Service1)
                .HasForeignKey(e => e.Service)
                .WillCascadeOnDelete(false);
        }
    }
}

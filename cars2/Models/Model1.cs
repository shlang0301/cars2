using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;


namespace cars2.Models
{

    public class Model1 : DbContext
    {
        public Model1()
            : base("Context")
        {
        }

        public virtual DbSet<Automobile> Automobiles { get; set; }
        public virtual DbSet<AutomobilesData> AutomobilesDatas { get; set; }
        public virtual DbSet<CarModel> CarModels { get; set; }
        public virtual DbSet<CarСonditions> CarСonditions { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Deal> Deals { get; set; }
        public virtual DbSet<Drive> Drives { get; set; }
        public virtual DbSet<Engines> Engines { get; set; }
        public virtual DbSet<Equipment> Equipments { get; set; }
        public virtual DbSet<RolesUser> RolesUsers { get; set; }
        public virtual DbSet<Transmission> Transmissions { get; set; }
        public virtual DbSet<TypesAuto> TypesAutoes { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Automobile>()
                .HasMany(e => e.AutomobilesDatas)
                .WithRequired(e => e.Automobile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AutomobilesData>()
                .Property(e => e.PriceOriginal)
                .HasPrecision(10, 4);

            modelBuilder.Entity<AutomobilesData>()
                .HasMany(e => e.Deals)
                .WithRequired(e => e.AutomobilesData)
                .HasForeignKey(e => e.AutomobileId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CarModel>()
                .HasMany(e => e.Automobiles)
                .WithRequired(e => e.CarModel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CarСonditions>()
                .HasMany(e => e.AutomobilesDatas)
                .WithRequired(e => e.CarСonditions)
                .HasForeignKey(e => e.CarConditionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Color>()
                .HasMany(e => e.Automobiles)
                .WithRequired(e => e.Color)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Drive>()
                .HasMany(e => e.Automobiles)
                .WithRequired(e => e.Drive)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Engines>()
                .HasMany(e => e.Automobiles)
                .WithRequired(e => e.Engine)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Equipment>()
                .HasMany(e => e.Automobiles)
                .WithRequired(e => e.Equipment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RolesUser>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.RolesUser)
                .HasForeignKey(e => e.RoleUserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transmission>()
                .HasMany(e => e.Automobiles)
                .WithRequired(e => e.Transmission)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TypesAuto>()
                .HasMany(e => e.Automobiles)
                .WithRequired(e => e.TypesAuto)
                .HasForeignKey(e => e.TypeAutoId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Deals)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}

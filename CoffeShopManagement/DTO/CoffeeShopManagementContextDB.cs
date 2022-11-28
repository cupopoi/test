using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CoffeShopManagement.DTO
{
    public partial class CoffeeShopManagementContextDB : DbContext
    {
        public CoffeeShopManagementContextDB()
            : base("name=CoffeeShopManagementContextDB")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<BillInfo> BillInfoes { get; set; }
        public virtual DbSet<Dish> Dishes { get; set; }
        public virtual DbSet<DishCategory> DishCategories { get; set; }
        public virtual DbSet<TableNumber> TableNumbers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Bill>()
            //    .HasMany(e => e.BillInfoes)
            //    .WithOptional(e => e.Bill)
            //    .HasForeignKey(e => e.IdBill);

            //modelBuilder.Entity<Dish>()
            //    .HasMany(e => e.BillInfoes)
            //    .WithOptional(e => e.Dish)
            //    .HasForeignKey(e => e.IdDish);

            //modelBuilder.Entity<DishCategory>()
            //    .HasMany(e => e.Dishes)
            //    .WithOptional(e => e.DishCategory)
            //    .HasForeignKey(e => e.IdDishCategory);

            //modelBuilder.Entity<TableNumber>()
            //    .HasMany(e => e.Bills)
            //    .WithOptional(e => e.TableNumber)
            //    .HasForeignKey(e => e.IdTableNumber);
        }
    }
}

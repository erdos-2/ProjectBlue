using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ProjectBlue.Model_Classes
{
    public class EniblaDbContext : DbContext
    {
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Offering> Offerings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region One-to-Many Relationships
            modelBuilder.Entity<Offering>()
                .HasRequired(o => o.Restaurant)
                .WithMany(r => r.Offerings)
                .HasForeignKey(o => o.RestaurantId);

            modelBuilder.Entity<Restaurant>()
                .HasRequired(r => r.Manager)
                .WithMany(m => m.Restaurants)
                .HasForeignKey(r => r.ManagerId);
            #endregion

            #region Many-to-Many Relationships
            // Favorite Offerings
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.FavoriteOfferings)
                .WithMany(o => o.FavoringCustomers)
                .Map(co =>
                        {
                            co.MapLeftKey("FavoringCustomerId");
                            co.MapRightKey("FavoriteOfferingId");
                            co.ToTable("CustomersOfferingsFav");
                        });

            // Favorite Restaurants
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.FavoriteRestaurants)
                .WithMany(r => r.FavoringCustomers)
                .Map(cr =>
                        {
                            cr.MapLeftKey("FavoringCustomerId");
                            cr.MapRightKey("FavoriteRestaurantId");
                            cr.ToTable("CustomersRestaurantsFav");
                        });

            // Offering Orders
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.OrderedOfferings)
                .WithMany(o => o.OrderingCustomers)
                .Map(co =>
                {
                    co.MapLeftKey("OrderingCustomerId");
                    co.MapRightKey("OrderedOfferingId");
                    co.ToTable("CustomersOfferingsOrd");
                });
            #endregion
        }
    }
}

using Microsoft.EntityFrameworkCore;
using SapatusinStore.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatusinStore.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {        
        }
        public DbSet<CustomerDTO> CustomerDTOs { get; set; }
        public DbSet<InventoryDTO> InventoryDTOs { get; set; }
        public DbSet<OrderDetailsDTO> OrderDetailsDTOs { get; set; }
        public DbSet<OrderDTO> OrderDTOs { get; set; }
        public DbSet<ProductDTO> ProductDTO { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerDTO>()
                .HasKey(c => c.CustomerId);

            modelBuilder.Entity<InventoryDTO>()
                .HasKey(i => i.InventoryId);

            modelBuilder.Entity<OrderDetailsDTO>()
                .HasKey(o => o.OrderDetailsID);

            modelBuilder.Entity<OrderDTO>()
                .HasKey(r => r.OrderId);

            modelBuilder.Entity<ProductDTO>()
                .HasKey(s => s.ShoeId);
        }
    }
}

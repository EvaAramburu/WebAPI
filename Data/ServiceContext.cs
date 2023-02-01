using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ServiceContext : DbContext
    {
        public ServiceContext(DbContextOptions<ServiceContext> options) : base(options){ }
        public DbSet<ItemEntity> Items { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<AdminEntity> Admins { get; set; }
        public DbSet<BuyerEntity> Buyers { get; set; }
        public DbSet<UserRol> UserRol { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ItemEntity>(entity =>
            {
                entity.ToTable("Items");

            });
            builder.Entity<OrderEntity>(order =>
            {
                order.ToTable("Orders");
                //order.HasOne<ItemEntity>().WithMany().HasForeignKey(o => o.ItemId);
                //order.HasOne<BuyerEntity>().WithMany().HasForeignKey(o => o.BuyerId);

            });
            builder.Entity<UserEntity>(entity =>
            {
                entity.ToTable("Users");
            });
            builder.Entity<AdminEntity>(entity =>
            {
                entity.ToTable("Admins");

            });
            builder.Entity<BuyerEntity>(entity =>
            {
                entity.ToTable("Buyers");

            });
            builder.Entity<UserRol>(entity =>
            {
                entity.ToTable("UserRol");

            });
        }

    }
    public class ServiceContextFactory : IDesignTimeDbContextFactory<ServiceContext>
    {
       public ServiceContext CreateDbContext(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true);
            var config = builder.Build();
            var connectionString = config.GetConnectionString("ServiceContext");
            var optionsBuilder = new DbContextOptionsBuilder<ServiceContext>();
            optionsBuilder.UseSqlServer(config.GetConnectionString("ServiceContext"));

            return new ServiceContext(optionsBuilder.Options);
        }
    }
}

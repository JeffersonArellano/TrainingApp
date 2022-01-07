using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp.Domain;
using TrainingApp.Domain.Entities;

namespace TrainingApp.Persistence
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Roles> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>(x =>
            x.HasOne(c => c.Role)
            .WithMany(c => c.Customers)
            .HasForeignKey(c => c.RoleId)
            );


        }
    }
}

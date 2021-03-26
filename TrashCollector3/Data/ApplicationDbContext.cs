﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TrashCollector3.Models;

namespace TrashCollector3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .HasData(
                new IdentityRole
                {
                    Name = "Customer",
                    NormalizedName = "CUSTOMER"
                },
                  new IdentityRole
                  {
                      Name = "Employee",
                      NormalizedName = "EMPLOYEE"
                  }
                );
        }

        public DbSet<TrashCollector3.Models.Employee> Employee { get; set; }

        public DbSet<TrashCollector3.Models.Customer> Customer { get; set; }
        public DbSet<CustomerPickupViewModel> customerPickupViewModels { get; set; }
    }
}

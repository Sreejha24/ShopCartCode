using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShoppingCart.Models;

namespace ShoppingCart.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ShoppingCart.Models.Order> Order { get; set; }
        public DbSet<ShoppingCart.Models.Product> Product { get; set; }
        public DbSet<ShoppingCart.Models.OrderDetail> OrderDetail { get; set; }
    }
}

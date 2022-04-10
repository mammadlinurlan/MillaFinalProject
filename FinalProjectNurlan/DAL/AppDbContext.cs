﻿using FinalProjectNurlan.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectNurlan.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Brand> Brands { get; set; }

        public DbSet<Size> Sizes { get; set; }
        public DbSet<Color> Colors { get; set; }

        public DbSet<ProductSizeColor> ProductSizeColors { get; set; }

        public DbSet<ProductColor> ProductColors { get; set; }

        public DbSet<BasketItem> BasketItems { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Status> Statuses { get; set; }

        public DbSet<Settings> Settings { get; set; }

        public DbSet<WishlistItem> WishlistItems { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
    }
}

using GenericRepositoryExampla.Entities.Model;
using GenericRepositoryExample.DataAccsess.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRepositoryExample.DataAccsess
{
    public class GenericDbContext :IdentityDbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        //{
        //    base.OnConfiguring(optionBuilder);
        //    optionBuilder.UseSqlServer("Server=DESKTOP-HFLUHER;Database=GenericDb;uid=seyma;pwd=123");

        //}
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //    builder.ApplyConfiguration(new ContentConfiguration());
        //    builder.ApplyConfiguration(new CategoryConfiguration());
        //}
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Content> Contents { get; set; }

        public GenericDbContext(DbContextOptions<GenericDbContext> options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public GenericDbContext()
        {
        }

       
    }
}

using GenericRepositoryExampla.Entities.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRepositoryExample.DataAccsess.Configurations
{
    class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(a => a.Category_Id);
            builder.Property(m => m.Category_Id).UseIdentityColumn();
            builder.Property(m => m.Title).IsRequired().HasMaxLength(50);
            builder.ToTable("Categories");
        }
    }
}

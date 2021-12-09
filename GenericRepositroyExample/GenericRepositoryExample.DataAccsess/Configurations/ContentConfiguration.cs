using GenericRepositoryExampla.Entities.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRepositoryExample.DataAccsess.Configurations
{
    public class ContentConfiguration : IEntityTypeConfiguration<Content>
    {
        public void Configure(EntityTypeBuilder<Content> builder)
        {
            builder.HasKey(w => w.Content_Id);
            builder.Property(w => w.Content_Id).UseIdentityColumn();
            builder.HasOne(w => w.Category).WithMany(a => a.Contents).HasForeignKey(w => w.Category_Id);
            builder.ToTable("Contents");
        }
    }
}

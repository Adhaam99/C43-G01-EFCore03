using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.ConfigurationModels
{
    public class TopicConfigurationModel : IEntityTypeConfiguration<Topic>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Topic> builder)
        {
            builder.HasMany(T => T.Courses)
                   .WithOne(C => C.Topic)
                   .HasForeignKey(C => C.Top_ID)
                   .OnDelete(DeleteBehavior.NoAction)
                   .IsRequired();
        }
    }
}

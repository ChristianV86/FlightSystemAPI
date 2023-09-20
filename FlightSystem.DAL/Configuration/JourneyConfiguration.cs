using FlightSystem.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem.DAL.Configuration
{
    public class JourneyConfiguration : IEntityTypeConfiguration<Journey>
    {
        public void Configure(EntityTypeBuilder<Journey> builder)
        {
            builder.Property(x => x.Id).HasColumnName("Id");
            builder.Property(x => x.Origin).IsRequired();
            builder.Property(x => x.Destination).IsRequired();
            builder.Property(x => x.Price).IsRequired();
        }
    }
}

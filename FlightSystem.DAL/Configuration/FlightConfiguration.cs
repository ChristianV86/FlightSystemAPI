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
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.Property(x => x.DepartureStation).IsRequired().HasMaxLength(3);
            builder.Property(x => x.ArrivalStation).IsRequired().HasMaxLength(3);            
            builder.Property(x => x.FlightCarrier).IsRequired().HasMaxLength(2);
            builder.Property(x => x.FlightNumber).IsRequired().HasMaxLength(4);
            builder.Property(x => x.Price).IsRequired();            
        }
    }
}

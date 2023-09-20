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
    public class JourneyFlightConfiguration : IEntityTypeConfiguration<JourneyFlight>
    {
        public void Configure(EntityTypeBuilder<JourneyFlight> builder)
        {
            builder.HasOne(x => x.Journey).WithMany()
                .HasForeignKey(x => x.JourneyId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Fligth).WithMany()
                .HasForeignKey(x => x.FlightId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

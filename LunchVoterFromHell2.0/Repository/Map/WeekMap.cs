using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Map
{
    public class WeekMap : EntityTypeConfiguration<Week>
    {
        public WeekMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Day)
                .IsRequired();

            // Relationships
            this.HasRequired(t => t.Restaurant)
                .WithMany(t => t.Days)
                .Map(m => m.MapKey("RestaurantID"));
        }
    }
}

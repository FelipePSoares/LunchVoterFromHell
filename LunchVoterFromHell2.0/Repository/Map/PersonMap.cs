using Entities;
using System.Data.Entity.ModelConfiguration;

namespace Repository.Map
{
    public class PersonMap : EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(256);

            // Relationships
            this.HasRequired(t => t.Group)
                .WithMany(t => t.Participants)
                .Map(m => m.MapKey("GroupID"));
        }
    }
}

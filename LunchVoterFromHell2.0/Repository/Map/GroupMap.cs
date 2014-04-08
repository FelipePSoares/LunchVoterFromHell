using Entities;
using System.Data.Entity.ModelConfiguration;

namespace Repository
{
    public class GroupMap : EntityTypeConfiguration<Group>
    {
        public GroupMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(256);

            // Relationships
            this.HasMany(t => t.Participants);

            this.HasRequired(t => t.Owner);
        }
    }
}

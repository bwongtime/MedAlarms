using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace MvcApplication2.Models.Mapping
{
    public class binary_fileMap : EntityTypeConfiguration<binary_file>
    {
        public binary_fileMap()
        {
            // Primary Key
            this.HasKey(t => t.binary_file_id);

            // Properties
            this.Property(t => t.binary_file_id)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.binary_file_address)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("binary_file");
            this.Property(t => t.binary_file_id).HasColumnName("binary_file_id");
            this.Property(t => t.binary_file_address).HasColumnName("binary_file_address");
            this.Property(t => t.binary_file_startime).HasColumnName("binary_file_startime");
        }
    }
}

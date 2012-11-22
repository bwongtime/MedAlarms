using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace MedAlarms.Models.Mapping
{
    public class user_infoMap : EntityTypeConfiguration<user_info>
    {
        public user_infoMap()
        {
            // Primary Key
            this.HasKey(t => t.user_id);

            // Properties
            this.Property(t => t.user_id)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.user_name)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.user_password)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.user_email)
                .HasMaxLength(255);

            this.Property(t => t.user_annotation_level)
                .HasMaxLength(255);

            this.Property(t => t.user_firstname)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.user_lastname)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("user_info");
            this.Property(t => t.user_id).HasColumnName("user_id");
            this.Property(t => t.user_name).HasColumnName("user_name");
            this.Property(t => t.user_password).HasColumnName("user_password");
            this.Property(t => t.num_annotation).HasColumnName("num_annotation");
            this.Property(t => t.last_annotation_time).HasColumnName("last_annotation_time");
            this.Property(t => t.user_email).HasColumnName("user_email");
            this.Property(t => t.user_annotation_level).HasColumnName("user_annotation_level");
            this.Property(t => t.user_firstname).HasColumnName("user_firstname");
            this.Property(t => t.user_lastname).HasColumnName("user_lastname");
        }
    }
}

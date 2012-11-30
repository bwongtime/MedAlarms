using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace MvcApplication2.Models.Mapping
{
    public class alarm_infoMap : EntityTypeConfiguration<alarm_info>
    {
        public alarm_infoMap()
        {
            // Primary Key
            this.HasKey(t => t.alarm_id);

            // Properties
            this.Property(t => t.alarm_id)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.binary_file_id)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.alarm_startime)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.alarm_level)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.alarm_parcode)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.alarm_name)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.alarm_message)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.alarm_duration)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.user_names)
                .HasMaxLength(255);

            this.Property(t => t.predetermined_result)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("alarm_info");
            this.Property(t => t.alarm_id).HasColumnName("alarm_id");
            this.Property(t => t.binary_file_id).HasColumnName("binary_file_id");
            this.Property(t => t.alarm_startime).HasColumnName("alarm_startime");
            this.Property(t => t.alarm_level).HasColumnName("alarm_level");
            this.Property(t => t.alarm_parcode).HasColumnName("alarm_parcode");
            this.Property(t => t.alarm_name).HasColumnName("alarm_name");
            this.Property(t => t.alarm_message).HasColumnName("alarm_message");
            this.Property(t => t.alarm_duration).HasColumnName("alarm_duration");
            this.Property(t => t.user_names).HasColumnName("user_names");
            this.Property(t => t.is_predetermined).HasColumnName("is_predetermined");
            this.Property(t => t.predetermined_result).HasColumnName("predetermined_result");

            // Relationships
            this.HasRequired(t => t.binary_file)
                .WithMany(t => t.alarm_info)
                .HasForeignKey(d => d.binary_file_id);

        }
    }
}

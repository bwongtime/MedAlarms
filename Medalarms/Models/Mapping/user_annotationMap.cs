using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace MvcApplication2.Models.Mapping
{
    public class user_annotationMap : EntityTypeConfiguration<user_annotation>
    {
        public user_annotationMap()
        {
            // Primary Key
            this.HasKey(t => t.annotation_id);

            // Properties
            this.Property(t => t.annotation_id)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.user_id)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.alarm_id)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.annotation_result)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("user_annotation");
            this.Property(t => t.annotation_id).HasColumnName("annotation_id");
            this.Property(t => t.user_id).HasColumnName("user_id");
            this.Property(t => t.alarm_id).HasColumnName("alarm_id");
            this.Property(t => t.annotation_result).HasColumnName("annotation_result");
            this.Property(t => t.annotation_time).HasColumnName("annotation_time");

            // Relationships
            this.HasRequired(t => t.alarm_info)
                .WithMany(t => t.user_annotation)
                .HasForeignKey(d => d.alarm_id);
            this.HasRequired(t => t.user_info)
                .WithMany(t => t.user_annotation)
                .HasForeignKey(d => d.user_id);

        }
    }
}

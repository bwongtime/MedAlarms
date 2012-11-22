using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace MedAlarms.Models.Mapping
{
    public class scoreMap : EntityTypeConfiguration<score>
    {
        public scoreMap()
        {
            // Primary Key
            this.HasKey(t => t.alarm_id);

            // Properties
            this.Property(t => t.alarm_id)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.annotation_ids)
                .HasMaxLength(255);

            this.Property(t => t.ground_truth)
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("score");
            this.Property(t => t.alarm_id).HasColumnName("alarm_id");
            this.Property(t => t.num_annotations).HasColumnName("num_annotations");
            this.Property(t => t.annotation_ids).HasColumnName("annotation_ids");
            this.Property(t => t.ground_truth).HasColumnName("ground_truth");
        }
    }
}

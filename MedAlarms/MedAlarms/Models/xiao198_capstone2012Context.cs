using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MedAlarms.Models.Mapping;

namespace MedAlarms.Models
{
    public class xiao198_capstone2012Context : DbContext
    {
        static xiao198_capstone2012Context()
        {
            Database.SetInitializer<xiao198_capstone2012Context>(null);
        }

		public xiao198_capstone2012Context()
			: base("Name=xiao198_capstone2012Context")
		{
		}

        public DbSet<alarm_info> alarm_info { get; set; }
        public DbSet<binary_file> binary_file { get; set; }
        public DbSet<score> scores { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<user_annotation> user_annotation { get; set; }
        public DbSet<user_info> user_info { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new alarm_infoMap());
            modelBuilder.Configurations.Add(new binary_fileMap());
            modelBuilder.Configurations.Add(new scoreMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new user_annotationMap());
            modelBuilder.Configurations.Add(new user_infoMap());
        }
    }
}

using System;
using System.Collections.Generic;

namespace MedAlarms.Models
{
    public class binary_file
    {
        public binary_file()
        {
            this.alarm_info = new List<alarm_info>();
        }

        public string binary_file_id { get; set; }
        public string binary_file_address { get; set; }
        public System.DateTime binary_file_startime { get; set; }
        public virtual ICollection<alarm_info> alarm_info { get; set; }
    }
}

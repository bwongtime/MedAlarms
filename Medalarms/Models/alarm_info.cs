using System;
using System.Collections.Generic;

namespace MvcApplication2.Models
{
    public class alarm_info
    {
        public alarm_info()
        {
            this.user_annotation = new List<user_annotation>();
        }

        public string alarm_id { get; set; }
        public string binary_file_id { get; set; }
        public string alarm_startime { get; set; }
        public string alarm_level { get; set; }
        public string alarm_parcode { get; set; }
        public string alarm_name { get; set; }
        public string alarm_message { get; set; }
        public string alarm_duration { get; set; }
        public string user_names { get; set; }
        public Nullable<int> is_predetermined { get; set; }
        public string predetermined_result { get; set; }
        public virtual binary_file binary_file { get; set; }
        public virtual ICollection<user_annotation> user_annotation { get; set; }
    }
}

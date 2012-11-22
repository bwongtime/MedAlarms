using System;
using System.Collections.Generic;

namespace MedAlarms.Models
{
    public class user_info
    {
        public user_info()
        {
            this.user_annotation = new List<user_annotation>();
        }

        public string user_id { get; set; }
        public string user_name { get; set; }
        public string user_password { get; set; }
        public Nullable<int> num_annotation { get; set; }
        public Nullable<System.DateTime> last_annotation_time { get; set; }
        public string user_email { get; set; }
        public string user_annotation_level { get; set; }
        public string user_firstname { get; set; }
        public string user_lastname { get; set; }
        public virtual ICollection<user_annotation> user_annotation { get; set; }
    }
}

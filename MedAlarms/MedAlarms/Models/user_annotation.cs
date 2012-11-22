using System;
using System.Collections.Generic;

namespace MedAlarms.Models
{
    public class user_annotation
    {
        public string annotation_id { get; set; }
        public string user_id { get; set; }
        public string alarm_id { get; set; }
        public string annotation_result { get; set; }
        public Nullable<System.DateTime> annotation_time { get; set; }
        public virtual alarm_info alarm_info { get; set; }
        public virtual user_info user_info { get; set; }
    }
}

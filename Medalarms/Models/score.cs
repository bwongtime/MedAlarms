using System;
using System.Collections.Generic;

namespace MvcApplication2.Models
{
    public class score
    {
        public string alarm_id { get; set; }
        public Nullable<int> num_annotations { get; set; }
        public string annotation_ids { get; set; }
        public string ground_truth { get; set; }
    }
}

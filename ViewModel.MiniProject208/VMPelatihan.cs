using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.MiniProject208
{
    public class VMPelatihan
    {
        public long id { get; set; }
        public Nullable<long> time_period_id { get; set; }
        public string name { get; set; }
        public Nullable<long> created_by { get; set; }
        public Nullable<System.DateTime> created_on { get; set; }
        public Nullable<long> modified_by { get; set; }
        public Nullable<System.DateTime> modified_on { get; set; }
        public Nullable<long> deleted_by { get; set; }
        public Nullable<System.DateTime> deleted_on { get; set; }
        public bool is_delete { get; set; }
        public Nullable<long> biodata_id { get; set; }
        public string training_name { get; set; }
        public string organizer { get; set; }
        public string training_year { get; set; }
        public string training_month { get; set; }
        public Nullable<int> training_duration { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string notes { get; set; }
    }
}

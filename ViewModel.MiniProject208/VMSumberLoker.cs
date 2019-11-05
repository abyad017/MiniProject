using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.MiniProject208
{
    public class VMSumberLoker
    {
        public long id { get; set; }
        public long created_by { get; set; }
        public System.DateTime created_on { get; set; }
        public Nullable<long> modified_by { get; set; }
        public Nullable<System.DateTime> modified_on { get; set; }
        public Nullable<long> deleted_by { get; set; }
        public Nullable<System.DateTime> deleted_on { get; set; }
        public bool is_delete { get; set; }
        public long biodata_id { get; set; }
        public string vacancy_source { get; set; }
        public string candidate_type { get; set; }
        public string event_name { get; set; }
        public string career_center_name { get; set; }
        public string referrer_name { get; set; }
        public string referrer_phone { get; set; }
        public string referrer_email { get; set; }
        public string other_source { get; set; }
        public string last_income { get; set; }
        public Nullable<System.DateTime> apply_date { get; set; }
    }
}

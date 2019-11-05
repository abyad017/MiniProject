using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.MiniProject208
{
    public class VMReschedule
    {
        public long id { get; set; }
        public long created_by { get; set; }
        public System.DateTime created_on { get; set; }
        public Nullable<long> modified_by { get; set; }
        public Nullable<System.DateTime> modified_on { get; set; }
        public Nullable<long> deleted_by { get; set; }
        public Nullable<System.DateTime> deleted_on { get; set; }
        public bool is_delete { get; set; }
        public string schedule_code { get; set; }
        public Nullable<System.DateTime> schedule_date { get; set; }
        public string time { get; set; }
        public Nullable<long> ro { get; set; }
        public Nullable<long> tro { get; set; }
        public Nullable<long> schedule_type_id { get; set; }
        public string location { get; set; }
        public string other_ro_tro { get; set; }
        public string notes { get; set; }
        public Nullable<bool> is_automatic_mail { get; set; }
        public Nullable<System.DateTime> sent_date { get; set; }
        public string status { get; set; }
        public long rencana_jadwal_id { get; set; }
        public long biodata_id { get; set; }
        public string name { get; set; }
        public string descripton { get; set; }
        public string fullname { get; set; }
        public string nick_name { get; set; }
        public string hobby { get; set; }
    }
}

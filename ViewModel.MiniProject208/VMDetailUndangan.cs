using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.MiniProject208
{
    public class VMDetailUndangan
    {
        //undangan +
        public string u_schedule_type;
        public string u_ro_name;
        public string u_tro_name;

        // undangan
        public long u_id { get; set; }
        public long u_created_by { get; set; }
        public System.DateTime u_created_on { get; set; }
        public Nullable<long> u_modified_by { get; set; }
        public Nullable<System.DateTime> u_modified_on { get; set; }
        public Nullable<long> u_deleted_by { get; set; }
        public Nullable<System.DateTime> u_deleted_on { get; set; }
        public bool u_is_delete { get; set; }
        public Nullable<long> u_schedule_type_id { get; set; }
        public Nullable<System.DateTime> u_invitation_date { get; set; }
        public string u_invitation_code { get; set; }
        public string u_time { get; set; }
        public Nullable<long> u_ro { get; set; }
        public Nullable<long> u_tro { get; set; }
        public string u_other_ro_tro { get; set; }
        public string u_location { get; set; }
        public string u_status { get; set; }
    }
}

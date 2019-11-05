using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.MiniProject208
{
    public class VMDetailRencanaJadwal
    {
        //penjadwaan +
        public string p_schedule_type;
        public string p_ro_name;
        public string p_tro_name;

        // penjadwalan
        public long p_id { get; set; }
        public long p_created_by { get; set; }
        public System.DateTime p_created_on { get; set; }
        public Nullable<long> p_modified_by { get; set; }
        public Nullable<System.DateTime> p_modified_on { get; set; }
        public Nullable<long> p_deleted_by { get; set; }
        public Nullable<System.DateTime> p_deleted_on { get; set; }
        public bool p_is_delete { get; set; }
        public string p_schedule_code { get; set; }
        public Nullable<System.DateTime> p_schedule_date { get; set; }
        public string p_time { get; set; }
        public Nullable<long> p_ro { get; set; }
        public Nullable<long> p_tro { get; set; }
        public Nullable<long> p_schedule_type_id { get; set; }
        public string p_location { get; set; }
        public string p_other_ro_tro { get; set; }
        public string p_notes { get; set; }
        public Nullable<bool> p_is_automatic_mail { get; set; }
        public Nullable<System.DateTime> p_sent_date { get; set; }
        public string p_status { get; set; }
    }
}

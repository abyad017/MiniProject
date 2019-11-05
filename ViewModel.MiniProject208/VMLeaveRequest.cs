using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.MiniProject208
{
    public class VMLeaveRequest
    {
        public long id { get; set; }
        public long id_tabel_req { get; set; }
        public long created_by { get; set; }
        public System.DateTime created_on { get; set; }
        public Nullable<long> modified_by { get; set; }
        public Nullable<System.DateTime> modified_on { get; set; }
        public Nullable<long> deleted_by { get; set; }
        public Nullable<System.DateTime> deleted_on { get; set; }
        public bool is_delete { get; set; }
        public Nullable<long> leave_name_id { get; set; }
        public System.DateTime start { get; set; }
        public System.DateTime end_ { get; set; }
        public string reason { get; set; }
        public string leave_contact { get; set; }
        public string leave_address { get; set; }
        public string leave_type { get; set; }
        public string name { get; set; }
        public string notes { get; set; }
    }
}

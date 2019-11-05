using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.MiniProject208
{
    public class VMCatatan
    {
        public string note_type;
        public string creator;

        public long id { get; set; }
        public long created_by { get; set; }
        public System.DateTime created_on { get; set; }
        public Nullable<long> modified_by { get; set; }
        public Nullable<System.DateTime> modified_on { get; set; }
        public Nullable<long> deleted_by { get; set; }
        public Nullable<System.DateTime> deleted_on { get; set; }
        public bool is_delete { get; set; }
        public long biodata_id { get; set; }
        public string title { get; set; }
        public Nullable<long> note_type_id { get; set; }
        public string notes { get; set; }
    }
}

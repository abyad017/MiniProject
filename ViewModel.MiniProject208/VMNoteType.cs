using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.MiniProject208
{
    public class VMNoteType
    {
        public long id { get; set; }
        public long created_by { get; set; }
        public System.DateTime created_on { get; set; }
        public Nullable<long> modify_by { get; set; }
        public Nullable<System.DateTime> modify_on { get; set; }
        public Nullable<long> delete_by { get; set; }
        public Nullable<System.DateTime> delete_on { get; set; }
        public bool is_delete { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}

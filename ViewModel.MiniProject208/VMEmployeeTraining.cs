using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.MiniProject208
{
    public class VMEmployeeTraining
    {
        public long id { get; set; }
        public long created_by { get; set; }
        public System.DateTime created_on { get; set; }
        public Nullable<long> modified_by { get; set; }
        public Nullable<System.DateTime> modified_on { get; set; }
        public Nullable<long> deleted_by { get; set; }
        public Nullable<System.DateTime> deleted_on { get; set; }
        public bool is_delete { get; set; }
        public long employee_id { get; set; }
        public long training_id { get; set; }
        public Nullable<long> training_organizer_id { get; set; }
        public Nullable<System.DateTime> training_date { get; set; }
        public Nullable<long> training_type_id { get; set; }
        public Nullable<long> certification_type_id { get; set; }
        public string status { get; set; }
        public string fullname { get; set; }
        public string name_trai { get; set; }
        public string name_to { get; set; }

    }
}

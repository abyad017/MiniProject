using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.MiniProject208
{
    public class VMTimesheet
    {
        public long timesheet_id { get; set; }
        public string name { get; set; }
        public string tanggalan { get; set; }
        public long client_id { get; set; }
        public long employee_id { get; set; }
        public bool is_placement_active { get; set; }
        public string status { get; set; }
        public long placement_id { get; set; }
        public long created_by { get; set; }
        public System.DateTime created_on { get; set; }
        public Nullable<long> modified_by { get; set; }
        public Nullable<System.DateTime> modified_on { get; set; }
        public Nullable<long> deleted_by { get; set; }
        public Nullable<System.DateTime> deleted_on { get; set; }
        public bool is_delete { get; set; }
        public System.DateTime timesheet_date { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public Nullable<bool> overtime { get; set; }
        public string start_ot { get; set; }
        public string end_ot { get; set; }
        public string activity { get; set; }
        public string user_approval { get; set; }
        public System.DateTime submitted_on { get; set; }
        public Nullable<System.DateTime> approved_on { get; set; }
        public string ero_status { get; set; }
        public Nullable<System.DateTime> sent_on { get; set; }
        public Nullable<System.DateTime> collected_on { get; set; }



        //Alfi
        //x_timesheet
        public long idTimeSheet { get; set; }
        public long id { get; set; }
        public string ends { get; set; }

        //x-placement
        public long idPlacement { get; set; }

        //client
        public long idClient { get; set; }
        public string user_client_name { get; set; }

        //employee
        public long idEmplo { get; set; }
        public string ero_email { get; set; }
        public long biodata_id { get; set; }

        //biodata
        public long idBio { get; set; }
        public string namaPgw { get; set; }

        //Alfi
    }
}

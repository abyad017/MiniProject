//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.MiniProject208
{
    using System;
    using System.Collections.Generic;
    
    public partial class x_riwayat_pelatihan
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
        public string training_name { get; set; }
        public string organizer { get; set; }
        public string training_year { get; set; }
        public string training_month { get; set; }
        public Nullable<int> training_duration { get; set; }
        public Nullable<long> time_period_id { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string notes { get; set; }
    }
}

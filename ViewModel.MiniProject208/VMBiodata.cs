using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.MiniProject208
{
    public class VMBiodata
    {
        public long idBio { get; set; }
        public string fullname { get; set; }
        public string nick_name { get; set; }
        public Nullable<bool> is_delete { get; set; }
        public Nullable<long> created_by { get; set; }
        public Nullable<System.DateTime> created_on { get; set; }
        public Nullable<long> BIOmodified_by { get; set; }
        public Nullable<System.DateTime> BIOmodified_on { get; set; }
        public Nullable<long> ADDRmodified_by { get; set; }
        public Nullable<System.DateTime> ADDRmodified_on { get; set; }
        public Nullable<long> deleted_by { get; set; }
        public Nullable<System.DateTime> deleted_on { get; set; }
        public string pob { get; set; }
        public System.DateTime dob { get; set; }
        public bool gender { get; set; }
        public long religion_id { get; set; }
        public long idAgama { get; set; }
        public string NamaAgama { get; set; }
        public Nullable<int> high { get; set; }
        public Nullable<int> weights { get; set; }
        public string nationality { get; set; }
        public string ethnic { get; set; }
        public string hobby { get; set; }
        public long identity_type_id { get; set; }
        public long idIden { get; set; }
        public string identityName { get; set; }
        public string identity_no { get; set; }
        public string email { get; set; }
        public string phone_number1 { get; set; }
        public string phone_number2 { get; set; }
        public string parent_phone_number { get; set; }
        public string child_sequence { get; set; }
        public string how_many_brothers { get; set; }
        public long marital_status_id { get; set; }
        public long idStatus { get; set; }
        public string marriage_year { get; set; }
        public string status { get; set; }
        public string address1 { get; set; }
        public string postal_code1 { get; set; }
        public string rt1 { get; set; }
        public string rw1 { get; set; }
        public string kelurahan1 { get; set; }
        public string kecamatan1 { get; set; }
        public string region1 { get; set; }
        public string address2 { get; set; }
        public string postal_code2 { get; set; }
        public string rt2 { get; set; }
        public string rw2 { get; set; }
        public string kelurahan2 { get; set; }
        public string kecamatan2 { get; set; }
        public string region2 { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.MiniProject208
{
    public class VMPelamar
    {

        public long id { get; set; }
        public long  idDtl { get; set; }
        public long idUdg { get; set; }

        public long idSch { get; set; }

        //[Required(ErrorMessage = "Fullname is required")]
        public string fullname { get; set; }

        //[Required(ErrorMessage = "NickName is required")]
        public string nick_name { get; set; }

        //[Required(ErrorMessage = "Pob is required")]
        public string pob { get; set; }

        //[Required(ErrorMessage = "dob is required")]
        public System.DateTime dob { get; set; }
        public bool gender { get; set; }
        public long religion_id { get; set; }
        public Nullable<int> high { get; set; }
        public Nullable<int> weights { get; set; }
        public string nationality { get; set; }
        public string ethnic { get; set; }
        public string hobby { get; set; }
        public long identity_type_id { get; set; }
        public string identity_no { get; set; }

        //[Required(ErrorMessage = "Email is required")]
        public string email { get; set; }
        public string phone_number1 { get; set; }
        public string phone_number2 { get; set; }
        public string parent_phone_number { get; set; }
        public string child_sequence { get; set; }
        public string how_many_brothers { get; set; }
        
        public long marital_status_id{ get; set; }
        public string marriage_year { get; set; }
        public long company_id { get; set; }


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

        public string school_name { get; set; }
        public string major { get; set; }

        public string invitation_code { get; set; }
        public Nullable<System.DateTime> invitation_date { get; set; }
        public string time { get; set; }
        public Nullable<long> schedule_type_id { get; set; }
        public Nullable<long> ro { get; set; }
        public Nullable<long> tro { get; set; }
        public string other_ro_tro { get; set; }
        public string location { get; set; }
        public string status { get; set; }

        public long biodata_id { get; set; }
        public string notes { get; set; }

        public string name { get; set; }
        public string name_ro { get; set; }
        public string name_tro { get; set; }

        //proses pelamar
        public Nullable<bool> is_process { get; set; }
        public Nullable<bool> is_complete { get; set; }
        public Nullable<bool> is_delete { get; set; }
    }
}

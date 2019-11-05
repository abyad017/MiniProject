using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.MiniProject208
{
    public class VM_Riwayat_Pendidikan
    {
        public long VM_Id_Riwayat_Pendidikan { get; set; }
        public long VM_Id_Education_Level { get; set; }
        public long VM_Create_by { get; set; }
        public DateTime VM_Created_on { get; set; }
        public string VM_Shcool_name { get; set; }
        public string VM_Education_Level { get; set; }
        public string VM_Jurusan { get; set; }
        public string VM_Kota { get; set; }
        public string VM_Negara { get; set; }
        public string VM_Tahun_Masuk { get; set; }
        public string VM_Tahun_Lulus { get; set; }
        public Nullable<decimal> VM_Ipk { get; set; }
        public string VM_Catatan { get; set; }

        public bool VM_Is_Delete { get; set; }
    }
}

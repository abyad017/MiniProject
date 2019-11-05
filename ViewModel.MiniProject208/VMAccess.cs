using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.MiniProject208
{
    public class VMAccess
    {
        public long id { get; set; }
        public string email { get; set; }
        public string abuid { get; set; }
        public long menutree_id { get; set; }
        public long role_id { get; set; }
        public string title { get; set; }
        public string menu_image_url { get; set; }
        public string menu_icon { get; set; }
        public int menu_order { get; set; }
        public int menu_level { get; set; }
        public Nullable<long> menu_parent { get; set; }
        public string menu_url { get; set; }
        public string menu_type { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public long addrbook_id { get; set; }
    }
}

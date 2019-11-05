//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Model.MiniProject208;
//using System.Data.Entity;
//using ViewModel.MiniProject208;


//namespace Repo.MiniProject208
//{
//    public class RescheduleRepo
//    {
//        public static List<VMPelamar> getAll()
//        {
//            List<VMPelamar> listudg = new List<VMPelamar>();
//            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
//            {
//                listudg = (from bio in db.x_biodata
//                           join pdk in db.x_riwayat_pendidikan on bio.id equals pdk.biodata_id
//                           join dudg in db.x_undangan_detail on bio.id equals dudg.biodata_id
//                           join udg in db.x_undangan on dudg.undangan_id equals udg.id
//                           //where fullname == KeyWord
//                           select new VMPelamar
//                           {
//                               id = udg.id,
//                               invitation_code = udg.invitation_code,
//                               fullname = bio.fullname,
//                               school_name = pdk.school_name,
//                               major = pdk.major,
//                               invitation_date = udg.invitation_date
//                           }).ToList();

//            }
//            return listudg;
//        }

//        public static List<VMPelamar> Search(string KeyWord)
//        {
//            List<VMPelamar> lstundangan = new List<VMPelamar>();
//            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
//            {
//                lstundangan = (from bio in db.x_biodata
//                               join pdk in db.x_riwayat_pendidikan on bio.id equals pdk.biodata_id
//                               join dudg in db.x_undangan_detail on bio.id equals dudg.biodata_id
//                               join udg in db.x_undangan on dudg.undangan_id equals udg.id
//                               where bio.fullname.Contains(KeyWord)
//                               select new VMPelamar
//                               {
//                                   id = udg.id,
//                                   invitation_code = udg.invitation_code,
//                                   fullname = bio.fullname,
//                                   school_name = pdk.school_name,
//                                   major = pdk.major,
//                                   invitation_date = udg.invitation_date
//                               }).ToList();

//            }
//            return lstundangan;
//        }

//        public static void saveAll(VMPelamar Plmr)
//        {

//            x_rencana_jadwal undangan = new x_rencana_jadwal();
//            x_rencana_jadwal_detail detail = new x_rencana_jadwal_detail();



//            undangan.schedule_date = Plmr.schedule_date;
//            undangan.time = Plmr.time;
//            undangan.schedule_type_id = Plmr.schedule_type_id;
//            undangan.ro = Plmr.biodata_id;
//            undangan.tro = Plmr.biodata_id;
//            undangan.other_ro_tro = Plmr.other_ro_tro;
//            undangan.location = Plmr.location;
//            undangan.schedule_code = getKodeUndangan();

//            detail.rencana_jadwal_id = getKodeDetail();
//            detail.biodata_id = Plmr.biodata_id;
//            undangan.notes = Plmr.notes;
//            detail.created_by = 1;
//            detail.created_on = System.DateTime.Now;
//            undangan.created_by = 1;
//            undangan.created_on = System.DateTime.Now;



//            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
//                try
//                {

//                    db.x_rencana_jadwal.Add(undangan);
//                    db.x_rencana_jadwal_detail.Add(detail);
//                    db.SaveChanges();
//                }
//                catch (Exception)
//                {
//                    throw;
//                }
//        }

//        public static string getKodeUndangan()
//        {
//            x_rencana_jadwal data = new x_rencana_jadwal();
//            long num = new long();
//            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
//            {
//                data = db.x_rencana_jadwal.OrderByDescending(a => a.id).FirstOrDefault();
//            }
//            if (data != null)
//            {
//                num = data.id + 1;
//            }
//            else
//            {
//                num = 1;
//            }
//            string kode = num.ToString();
//            string zero = "0";
//            string kode_trans = "UD";
//            for (int i = 4; i >= 0; i--)
//            {
//                if (i == kode.Length)
//                {
//                    kode_trans = kode_trans + kode;
//                    break;
//                }
//                else
//                {
//                    kode_trans = kode_trans + zero;
//                }
//            }

//            return kode_trans;
//        }

//        public static long getKodeDetail()
//        {
//            x_undangan data = new x_undangan();
//            long num = new long();
//            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
//            {
//                data = db.x_undangan.OrderByDescending(a => a.id).FirstOrDefault();
//            }
//            if (data != null)
//            {
//                num = data.id + 1;
//            }
//            else
//            {
//                num = 1;
//            }
//            return num;
//        }

//        public static List<x_schedule_type> getSchedule()
//        {
//            List<x_schedule_type> lstschedule = new List<x_schedule_type>();
//            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
//            {
//                lstschedule = db.x_schedule_type.ToList();
//            }
//            return lstschedule;
//        }

//        public static List<x_biodata> getBiodata()
//        {
//            List<x_biodata> lstbiodata = new List<x_biodata>();
//            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
//            {
//                lstbiodata = db.x_biodata.ToList();
//            }
//            return lstbiodata;
//        }
//        public static List<x_undangan> getUndangan()
//        {
//            List<x_undangan> lstundangan = new List<x_undangan>();
//            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
//            {
//                lstundangan = db.x_undangan.ToList();
//            }
//            return lstundangan;
//        }

//        public static List<x_undangan_detail> getDetUndangan()
//        {
//            List<x_undangan_detail> lstdetundangan = new List<x_undangan_detail>();
//            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
//            {
//                lstdetundangan = db.x_undangan_detail.ToList();
//            }
//            return lstdetundangan;
//        }

//        public static VMPelamar getDataByKode(long num)
//        {

//            VMPelamar list = new VMPelamar();

//            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
//            {
//                //list = (from udg in db.x_undangan
//                //        join dudg in db.x_undangan_detail on udg.id equals dudg.undangan_id
//                //        join bio in db.x_biodata on dudg.biodata_id equals bio.id
//                //        join sch in db.x_schedule_type on udg.schedule_type_id equals sch.id
//                //        where udg.id == num
//                list = (from bio in db.x_biodata
//                        join dudg in db.x_undangan_detail on bio.id equals dudg.biodata_id
//                        join udg in db.x_undangan on dudg.undangan_id equals udg.id
//                        join sch in db.x_schedule_type on udg.schedule_type_id equals sch.id
//                        where udg.id == num
//                        select new VMPelamar
//                        {

//                            idUdg = udg.id,
//                            biodata_id = bio.id,
//                            idSch = sch.id,
//                            invitation_date = udg.invitation_date,
//                            time = udg.time,
//                            fullname = bio.fullname,
//                            schedule_type_id = udg.schedule_type_id,
//                            ro = udg.ro,
//                            tro = udg.tro,
//                            other_ro_tro = udg.other_ro_tro,
//                            location = udg.location,
//                            notes = dudg.notes

//                        }).FirstOrDefault();
//            }
//            return list;
//        }
//        // Order Data By Asc
        

//        // Order Data By Desc
//        public static List<VMPelamar> OrderByDesc()
//        {
//            List<VMPelamar> list = new List<VMPelamar>();
//            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
//            {
//                list = (from udg in db.x_undangan
//                        join dudg in db.x_undangan_detail on udg.id equals dudg.undangan_id
//                        join bio in db.x_biodata on dudg.biodata_id equals bio.id
//                        join pen in db.x_riwayat_pendidikan on bio.id equals pen.biodata_id
//                        orderby udg.id descending
//                        //.Where(a => a.is_delete == false).OrderByDescending(a => a.id)

//                        select new VMPelamar
//                        {
//                            id = udg.id,
//                            fullname = bio.fullname,
//                            school_name = pen.school_name,
//                            major = pen.major,

//                        }
//                        ).ToList();
//            }
//            return list;
//        }
//    }
//}

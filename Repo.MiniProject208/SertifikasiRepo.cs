//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Model.MiniProject208;
//using Repo.MiniProject208;
//using ViewModel.MiniProject208;
//using System.Globalization;

//namespace Repo.MiniProject208
//{
//    public class SertifikasiRepo
//    {
//        public static List<x_sertifikasi> GetData()
//        {
//            List<x_sertifikasi> list = new List<x_sertifikasi>();
//            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
//            {
//                list = db.x_sertifikasi.Where(a => a.is_delete == false).ToList();
//            }
//            return list;
//        }

//        public static void simpan(x_sertifikasi sertifikasi)
//        {
//            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
//            {
//                sertifikasi.biodata_id = 1;
//                sertifikasi.is_delete = false;
//                sertifikasi.created_on = System.DateTime.Now;
//                sertifikasi.created_by = 1;
//                db.x_sertifikasi.Add(sertifikasi);
//                db.SaveChanges();

//            }
//        }

//        public static x_sertifikasi getDatabyId(Int64 id)
//        {
//            x_sertifikasi dt = new x_sertifikasi();
//            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
//            {
//                dt = db.x_sertifikasi.Find(id);// find data base on id
//            }
//            return dt;
//        }

//        public static bool ubah(x_sertifikasi dk)
//        {
//            try
//            {
//                using (DBMiniProject208Entities db = new DBMiniProject208Entities())
//                {
//                    x_sertifikasi dataLama = db.x_sertifikasi.Where(a => a.id == dk.id).FirstOrDefault();
//                    dataLama.certificate_name = dk.certificate_name;
//                    dataLama.publisher = dk.publisher;
//                    dataLama.valid_start_month = dk.valid_start_month;
//                    dataLama.valid_start_year = dk.valid_start_year;
//                    dataLama.until_month = dk.until_month;
//                    dataLama.until_year = dk.until_year;
//                    dataLama.notes = dk.notes;
//                    dataLama.modified_by = 1;
//                    dataLama.modified_on = System.DateTime.Now;

//                    db.Entry(dataLama).State = System.Data.Entity.EntityState.Modified;
//                    db.SaveChanges();
//                }
//                return true;

//            }
//            catch (Exception)
//            {
//                return false;
//            }
//        }

//        public static bool hapus(Int64 id)
//        {
//            try
//            {
//                x_sertifikasi dtSertifikasi = new x_sertifikasi();
//                using (DBMiniProject208Entities db = new DBMiniProject208Entities())
//                {
//                    dtSertifikasi = db.x_sertifikasi.Where(a => a.id == id).FirstOrDefault();
//                    dtSertifikasi.deleted_by = 1;
//                    dtSertifikasi.deleted_on = System.DateTime.Now;
//                    dtSertifikasi.is_delete = true;

//                    db.Entry(dtSertifikasi).State = System.Data.Entity.EntityState.Modified;
//                    db.SaveChanges();
//                }
//                return true;
//            }
//            catch (Exception)
//            {
//                return false;
//            }
//        }

//        public static List<Pilihan> GetMonthList()
//        {
//            DateTime month = new DateTime(2000, 1, 1);
//            List<Pilihan> list = new List<Pilihan>();
//            for (int i = 1; i <= 12; i++)
//            {
//                Pilihan obj = new Pilihan();
//                obj.Value = i;
//                obj.Text = month.ToString("MMMM", CultureInfo.CreateSpecificCulture("id"));
//                month = month.AddMonths(1);
//                list.Add(obj);
//            }
//            return list;
//        }
//        public static List<Pilihan> GetYear()
//        {
//            DateTime tahun = new DateTime(2019, 1, 1);
//            List<Pilihan> list = new List<Pilihan>();
//            for (int i = 0; i <= 12; i++)
//            {
//                Pilihan plh = new Pilihan();
//                plh.Text = tahun.Year.ToString();
//                list.Add(plh);
//                tahun = tahun.AddYears(-1);
//            }
//            return list;
//        }
//    }

//}
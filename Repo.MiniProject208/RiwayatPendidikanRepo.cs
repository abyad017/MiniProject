//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Model.MiniProject208;
//using ViewModel.MiniProject208;
//using System.Globalization;

//namespace Repo.MiniProject208
//{
//    public class RiwayatPendidikanRepo
//    {
//        public static List<VM_Riwayat_Pendidikan> getAll()
//        {
//            List<VM_Riwayat_Pendidikan> list = new List<VM_Riwayat_Pendidikan>();
//            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
//            {
//                list = (from rp in db.x_riwayat_pendidikan.Where(a => a.is_delete == false)
//                        join el in db.x_education_level on rp.education_level_id equals el.id
//                        orderby rp.id descending
//                        select new VM_Riwayat_Pendidikan 
//                        {
//                            VM_Id_Riwayat_Pendidikan = rp.id,
//                            VM_Shcool_name = rp.school_name,
//                            VM_Id_Education_Level = el.id,
//                            VM_Education_Level = el.name,
//                            VM_Tahun_Masuk = rp.entry_year,
//                            VM_Tahun_Lulus = rp.graduation_year,
//                            VM_Jurusan = rp.major,
//                            VM_Ipk = rp.gpa,
//                            VM_Is_Delete = rp.is_delete

//                        }).ToList();
//            }
//            return list;
//        }

//        public static List<VM_Riwayat_Pendidikan> getAll(long biodataid)
//        {
//            List<VM_Riwayat_Pendidikan> list = new List<VM_Riwayat_Pendidikan>();
//            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
//            {
//                list = (from rp in db.x_riwayat_pendidikan.Where(a => a.is_delete == false)
//                        join el in db.x_education_level on rp.education_level_id equals el.id
//                        where rp.biodata_id == biodataid
//                        select new VM_Riwayat_Pendidikan
//                        {
//                            VM_Id_Riwayat_Pendidikan = rp.id,
//                            VM_Shcool_name = rp.school_name,
//                            VM_Id_Education_Level = el.id,
//                            VM_Education_Level = el.name,
//                            VM_Tahun_Masuk = rp.entry_year,
//                            VM_Tahun_Lulus = rp.gradution_year,
//                            VM_Jurusan = rp.major,
//                            VM_Ipk = rp.gpa,
//                            VM_Is_Delete = rp.is_delete

//                        }).ToList();
//            }
//            return list;
//        }


//        public static x_riwayat_pendidikan getDatabyId(long id)
//        {
//            x_riwayat_pendidikan dt = new x_riwayat_pendidikan();
//            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
//            {
//                dt = db.x_riwayat_pendidikan.Find(id);// find data base on id
//            }
//            return dt;
//        }

//        public static void saveAll(x_riwayat_pendidikan riwayatpendidikan)
//        {
//            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
//            {
//                riwayatpendidikan.is_delete = false;
//                riwayatpendidikan.biodata_id = 1;
//                riwayatpendidikan.created_by = 1;
//                riwayatpendidikan.created_on = System.DateTime.Now;
//                db.x_riwayat_pendidikan.Add(riwayatpendidikan);
//                db.SaveChanges();

//            }
//        }

//        public static bool SimpanEdit(x_riwayat_pendidikan riwayatpendidikan)
//        {
//            try
//            {

//                using (DBMiniProject208Entities db = new DBMiniProject208Entities())
//                {
//                    x_riwayat_pendidikan data_old = getDatabyId(riwayatpendidikan.id);
//                    data_old.school_name = riwayatpendidikan.school_name;
//                    data_old.education_level_id = riwayatpendidikan.education_level_id;
//                    data_old.major = riwayatpendidikan.major;
//                    data_old.city = riwayatpendidikan.city;
//                    data_old.country = riwayatpendidikan.country;
//                    data_old.entry_year = riwayatpendidikan.entry_year;
//                    data_old.gradution_year = riwayatpendidikan.gradution_year;
//                    data_old.gpa = riwayatpendidikan.gpa;
//                    data_old.notes = riwayatpendidikan.notes;
//                    data_old.modified_by = 1;
//                    data_old.modified_on = System.DateTime.Now;

//                    db.Entry(data_old).State = System.Data.Entity.EntityState.Modified;
//                    db.SaveChanges();
//                }
//                return true;

//            }
//            catch (Exception)
//            {
//                return false;
//            }
//        }

//        public static bool hapus(long id_riwayat_pendidikan)
//        {
//            try
//            {
//                x_riwayat_pendidikan data_riwayat_pendidikan = new x_riwayat_pendidikan();
//                using (DBMiniProject208Entities db = new DBMiniProject208Entities())
//                {
//                    data_riwayat_pendidikan = db.x_riwayat_pendidikan.Where(a => a.id == id_riwayat_pendidikan).FirstOrDefault();
//                    data_riwayat_pendidikan.is_delete = true;
//                    data_riwayat_pendidikan.delete_by = 1;
//                    data_riwayat_pendidikan.delete_on = System.DateTime.Now;

//                    db.Entry(data_riwayat_pendidikan).State = System.Data.Entity.EntityState.Modified;
//                    db.SaveChanges();
//                }
//                return true;
//            }
//            catch (Exception)
//            {
//                return false;
//            }
//        }

//        public static List<x_education_level> geteducationlevel()
//        {
//            List<x_education_level> lsteducationlevel = new List<x_education_level>();
//            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
//            {
//                lsteducationlevel = db.x_education_level.ToList();
//            }
//            return lsteducationlevel;
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
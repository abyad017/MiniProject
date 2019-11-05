using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.MiniProject208;
using System.Data.Entity;
using System.Globalization;

namespace Repo.MiniProject208
{
    public class RiwayatRepo
    {
        public static List<x_riwayat_pekerjaan> getAll()
        {
            List<x_riwayat_pekerjaan> list = new List<x_riwayat_pekerjaan>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                list = db.x_riwayat_pekerjaan.Where(a => a.is_delete == false && a.biodata_id == 1).ToList();
            }
            return list;

        }
        public static void saveAll(x_riwayat_pekerjaan prj)
        {
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                prj.created_by = 1;
                prj.created_on = System.DateTime.Now;
                prj.is_delete = false;
                prj.biodata_id = 1;
                db.x_riwayat_pekerjaan.Add(prj);
                db.SaveChanges();

            }
                //try
                //{
                //    prj.created_by = 1;
                //    prj.created_on = System.DateTime.Now;
                //    prj.is_delete = false;
                //    prj.biodata_id = 1;
                //    db.x_riwayat_pekerjaan.Add(prj);
                //    db.SaveChanges();
                //}
                //catch (Exception)
                //{
                //    throw;
                //}
        }
        public static x_riwayat_pekerjaan getDataByID(long ID)
        {
            x_riwayat_pekerjaan dtPrj = new x_riwayat_pekerjaan();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                dtPrj = db.x_riwayat_pekerjaan.Find(ID);
            }
            return dtPrj;
        }

        public static bool simpanEdit(x_riwayat_pekerjaan dtPrj)
        {
            try
            {
                using (DBMiniProject208Entities db = new DBMiniProject208Entities())
                {
                    x_riwayat_pekerjaan dataLama = db.x_riwayat_pekerjaan.Where(a => a.biodata_id == 1).FirstOrDefault();
                    dataLama.company_name = dtPrj.company_name;
                    dataLama.city = dtPrj.city;
                    dataLama.country = dtPrj.country;
                    dataLama.join_month = dtPrj.join_month;
                    dataLama.join_year = dtPrj.join_year;
                    dataLama.resign_month = dtPrj.resign_month;
                    dataLama.resign_year = dtPrj.resign_year;
                    dataLama.last_position = dtPrj.last_position;
                    dataLama.income = dtPrj.income;
                    dataLama.is_it_related = dtPrj.is_it_related;
                    dataLama.about_job = dtPrj.about_job;
                    dataLama.notes = dtPrj.notes;
                    dataLama.is_delete = false;
                    dataLama.modified_by = 1;
                    dataLama.modified_on = System.DateTime.Now;
                    db.Entry(dtPrj).State = EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Delete(long delid)
        {


            try
            {
                x_riwayat_pekerjaan dtfromdb = new x_riwayat_pekerjaan();
                using (DBMiniProject208Entities db = new DBMiniProject208Entities())
                {
                    dtfromdb = db.x_riwayat_pekerjaan.Where(a => a.id == delid).FirstOrDefault();
                    dtfromdb.is_delete = true;
                    db.Entry(dtfromdb).State = EntityState.Modified;
                    db.SaveChanges();
                }
                return true;

            }
            catch (Exception)
            {

                return false;
            }

        }
        
        public static List<Bulan> getJoinBulan()
        {
            DateTime bulan = new DateTime(2000, 1, 1);
            List<Bulan> list = new List<Bulan>();
            for (int i = 1; i <= 12; i++)
            {
                Bulan bln = new Bulan();
                bln.idJoin = i;
                bln.join = bulan.ToString("MMMM", CultureInfo.CreateSpecificCulture("id"));

                bulan = bulan.AddMonths(1);
                list.Add(bln);
            }
            return list;
        }
        public static List<Tahun> getJoinTahun()
        {
            DateTime tahun = System.DateTime.Now;
            List<Tahun> list = new List<Tahun>();
            for (int i = 0; i <= 12; i++)
            {
                Tahun thn = new Tahun();
                
                thn.join = tahun.Year.ToString();
                list.Add(thn);
                tahun = tahun.AddYears(-1);
            }
            return list;
        }

        public static List<Bulan> getResignBulan()
        {
            DateTime bulan = new DateTime(2000, 1, 1);
            List<Bulan> list = new List<Bulan>();
            for (int i = 1; i <= 12; i++)
            {
                Bulan bln = new Bulan();
                bln.idResign = i;
                bln.resign = bulan.ToString("MMMM", CultureInfo.CreateSpecificCulture("id"));

                bulan = bulan.AddMonths(1);
                list.Add(bln);
            }
            return list;
        }
        public static List<Tahun> getResignTahun()
        {
            DateTime tahun = System.DateTime.Now;
            List<Tahun> list = new List<Tahun>();
            for (int i = 0; i <= 12; i++)
            {
                Tahun thn = new Tahun();
                
                thn.resign = tahun.Year.ToString();
                list.Add(thn);
                tahun = tahun.AddYears(-1);
            }
            return list;
        }


    }
    public class related
    {
        public bool is_it_related { get; set; }

    }

    public class Bulan
    {
        public int idJoin { get; set; }
        public string join { get; set; }
        public int idResign { get; set; }
        public string resign { get; set; }
    }
    public class Tahun
    {
        public int idJoin { get; set; }
        public string join { get; set; }
        public int idResign { get; set; }
        public string resign { get; set; }
    }
    
}

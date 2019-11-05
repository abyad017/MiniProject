using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.MiniProject208;
using System.Data.Entity;
using ViewModel.MiniProject208;
using System.Globalization;

namespace Repo.MiniProject208
{
    public class PelatihanRepo
    {
        public static List<VMPelatihan> getPelatihan()
        {
            List<VMPelatihan> listplt = new List<VMPelatihan>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                listplt = (from plt in db.x_riwayat_pelatihan/*.Where(a => a.biodata_id == 1 && a.is_delete == false)*/
                           join prd in db.x_time_period on plt.time_period_id equals prd.id
                           //join bio in db.x_biodata on plt.biodata_id equals bio.id
                           where plt.is_delete == false
                           select new VMPelatihan
                           {
                               biodata_id = plt.biodata_id,
                               training_name = plt.training_name,
                               organizer = plt.organizer,
                               training_year = plt.training_year,
                               training_month = plt.training_month,
                               training_duration = plt.training_duration,
                               time_period_id = plt.time_period_id,
                               name = prd.name,
                               id = plt.id
                           }).ToList();

            }
            return listplt;
        }
        public static List<VMPelatihan> getPelatihan(long bioid)
        {
            List<VMPelatihan> listplt = new List<VMPelatihan>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                listplt = (from plt in db.x_riwayat_pelatihan/*.Where(a => a.is_delete == false)*/
                           join prd in db.x_time_period on plt.time_period_id equals prd.id
                           //join bio in db.x_biodata on plt.biodata_id equals bio.id
                           where plt.biodata_id == bioid && plt.is_delete == false
                           
                           select new VMPelatihan
                           {
                               biodata_id = plt.biodata_id,
                               training_name = plt.training_name,
                               organizer = plt.organizer,
                               training_year = plt.training_year,
                               training_month = plt.training_month,
                               training_duration = plt.training_duration,
                               time_period_id = plt.time_period_id,
                               name = prd.name,
                               id = plt.id
                           }).ToList();

            }
            return listplt;
        }

        public static void saveAll(x_riwayat_pelatihan plt)
        {
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
                try
                {
                    //plt.biodata_id = 
                    plt.created_by = 1;
                    plt.created_on = System.DateTime.Now;
                    plt.is_delete = false;
                    db.x_riwayat_pelatihan.Add(plt);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
        }
        
        public static List<x_time_period> getdataperiod()
        {
            List<x_time_period> list = new List<x_time_period>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                list = db.x_time_period.ToList();
            }
            return list;
        }
        public static x_riwayat_pelatihan getDataByID(long ID)
        {
            x_riwayat_pelatihan dt = new x_riwayat_pelatihan();

            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                dt = db.x_riwayat_pelatihan.Find(ID);
            }
            return dt;
        }
        public static bool SimpanEdit(x_riwayat_pelatihan pltedit)
        {
            try
            {
                using (DBMiniProject208Entities db = new DBMiniProject208Entities())
                {
                    x_riwayat_pelatihan pltdb = db.x_riwayat_pelatihan.Find(pltedit.id);
                    //x_riwayat_pelatihan pltdb = db.x_riwayat_pelatihan.Where(a => a.id == pltedit.id).FirstOrDefault();
                    pltdb.id = pltedit.id;
                    pltdb.training_name = pltedit.training_name;
                    pltdb.training_month = pltedit.training_month;
                    pltdb.training_year = pltedit.training_year;
                    pltdb.city = pltedit.city;
                    pltdb.organizer = pltedit.organizer;
                    pltdb.training_duration = pltedit.training_duration;
                    pltdb.time_period_id = pltedit.time_period_id;
                    pltdb.notes = pltedit.notes;
                    pltdb.modified_by = 1;
                    pltdb.modified_on = System.DateTime.Now;

                    db.Entry(pltdb).State = EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }

            catch (Exception)
            {
                //throw;
                return false;
            }
        }

        public static bool Delete(long delid1)
        {
            try
            {
                x_riwayat_pelatihan dtpelatihanFromDb = new x_riwayat_pelatihan();
                using (DBMiniProject208Entities db = new DBMiniProject208Entities())
                {
                    dtpelatihanFromDb = db.x_riwayat_pelatihan.Where(a => a.id == delid1).FirstOrDefault();
                    dtpelatihanFromDb.is_delete = true;
                    dtpelatihanFromDb.deleted_by = 1;
                    dtpelatihanFromDb.deleted_on = System.DateTime.Now;
                    db.Entry(dtpelatihanFromDb).State = EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
    
}


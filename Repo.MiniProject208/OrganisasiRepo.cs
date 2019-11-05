using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.MiniProject208;
using System.Data.Entity;

namespace Repo.MiniProject208
{
    public class OrganisasiRepo
    {
        public static List<x_organisasi> getAll()
        {
            List<x_organisasi> dtorganisasi = new List<x_organisasi>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                dtorganisasi = db.x_organisasi.Where(a => a.is_deleted == false && a.biodata_id == 1).ToList();
            }
            return dtorganisasi;
        }
        public static List<x_organisasi> getAll(long bioid)
        {
            List<x_organisasi> dtorganisasi = new List<x_organisasi>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                dtorganisasi = db.x_organisasi.Where(a => a.is_deleted == false && a.biodata_id == bioid).ToList();
            }
            return dtorganisasi;
        }
        public static void saveAll(x_organisasi org)
        {
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
                try
                {
                    org.created_by = 1;
                    org.created_on = System.DateTime.Now;
                    org.is_deleted = false;
                    org.biodata_id = 1;
                    db.x_organisasi.Add(org);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
        }
        
        public static x_organisasi getDataByID(long a)
        {
            x_organisasi dt = new x_organisasi();

            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                dt = db.x_organisasi.Find(a);
            }
            return dt;
        }

        public static bool SimpanEdit(x_organisasi orgedit)
        {
            try
            {
                using (DBMiniProject208Entities db = new DBMiniProject208Entities())
                {
                    //  x_organisasi orgdb = db.x_organisasi.Find(orgedit.id);
                    x_organisasi orgdb = db.x_organisasi.Where(a => a.biodata_id == 1).FirstOrDefault();
                    orgdb.name = orgedit.name;
                    orgdb.position = orgedit.position;
                    orgdb.entry_year = orgedit.entry_year;
                    orgdb.exit_year = orgedit.exit_year;
                    orgdb.responsibility = orgedit.responsibility;
                    orgdb.notes = orgedit.notes;
                    orgdb.modified_by = 1;
                    orgdb.modified_on = System.DateTime.Now;
                    db.Entry(orgdb).State = EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }

            catch (Exception)
            {
                //throw e;
                return false;
            }
        }

        public static bool Delete(long delid)
        {
            try
            {
                x_organisasi dtorganisasiFromDb = new x_organisasi();
                using (DBMiniProject208Entities db = new DBMiniProject208Entities())
                {
                    dtorganisasiFromDb = db.x_organisasi.Where(a => a.id == delid).FirstOrDefault();
                    dtorganisasiFromDb.is_deleted = true;
                    dtorganisasiFromDb.deleted_by = 1;
                    dtorganisasiFromDb.deleted_on = System.DateTime.Now;
                    db.Entry(dtorganisasiFromDb).State = EntityState.Modified;
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


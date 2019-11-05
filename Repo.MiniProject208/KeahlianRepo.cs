using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.MiniProject208;
using ViewModel.MiniProject208;


namespace Repo.MiniProject208
{
    public class KeahlianRepo
    {
        // Get Data Keahlian
        public static List<VMKeahlian> getAll()
        {
            List<VMKeahlian> listKeahlian = new List<VMKeahlian>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                listKeahlian = (from skill in db.x_keahlian.Where(a => a.is_delete == false)
                                join lvl in db.x_skill_level on skill.skill_level_id equals lvl.id

                                select new VMKeahlian
                                {
                                    id = skill.id,
                                    skill_name = skill.skill_name,
                                    name = lvl.name,
                                    notes = skill.notes

                                }).ToList();
            }
            return listKeahlian;
        }

        // Get Data Keahlian (Cari)
        public static List<VMKeahlian> getAll(string cari2)
        {
            long carilong = long.Parse(cari2);
            List<VMKeahlian> listKeahlian = new List<VMKeahlian>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                listKeahlian = (from skill in db.x_keahlian.Where(a => a.is_delete == false)
                                join lvl in db.x_skill_level on skill.skill_level_id equals lvl.id
                                join b in db.x_biodata on skill.biodata_id equals b.id
                                where skill.biodata_id == carilong || b.fullname == cari2
                                select new VMKeahlian
                                {
                                    biodata_id = b.id,
                                    id = skill.id,
                                    skill_name = skill.skill_name,
                                    name = lvl.name,
                                    notes = skill.notes

                                }).ToList();
            }
            return listKeahlian;
        }

        // Get Data Level Keahlian (Select Options)
        public static List<x_skill_level> getLevel()
        {
            List<x_skill_level> list = new List<x_skill_level>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                list = db.x_skill_level.ToList();
            }
            return list;
        }

        //
        public static x_keahlian getDatabyId(Int64 id)
        {
            x_keahlian dt = new x_keahlian();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                dt = db.x_keahlian.Find(id);// find data base on id
            }
            return dt;
        }

        //
        public static void saveAll(x_keahlian keahlian)
        {
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                keahlian.biodata_id = 2;
                keahlian.is_delete = false;
                keahlian.created_on = System.DateTime.Now;
                keahlian.created_by = 1;
                db.x_keahlian.Add(keahlian);
                db.SaveChanges();

            }
        }

        //
        public static bool SimpanEdit(x_keahlian dk)
        {
            try
            {
                using (DBMiniProject208Entities db = new DBMiniProject208Entities())
                {
                    x_keahlian dataLama = db.x_keahlian.Where(a => a.id == dk.id).FirstOrDefault();
                    dataLama.skill_name = dk.skill_name;
                    dataLama.notes = dk.notes;
                    dataLama.skill_level_id = dk.skill_level_id;
                    dataLama.modified_by = 1;
                    dataLama.modified_on = System.DateTime.Now;

                    db.Entry(dataLama).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        //
        public static bool hapus(Int64 id)
        {
            try
            {
                x_keahlian dtKeahlianFromDb = new x_keahlian();
                using (DBMiniProject208Entities db = new DBMiniProject208Entities())
                {
                    dtKeahlianFromDb = db.x_keahlian.Where(a => a.id == id).FirstOrDefault();
                    dtKeahlianFromDb.is_delete = true;

                    db.Entry(dtKeahlianFromDb).State = System.Data.Entity.EntityState.Modified;
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

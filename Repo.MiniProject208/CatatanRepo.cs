using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.MiniProject208;
using ViewModel.MiniProject208;
using System.Data.Entity;

namespace Repo.MiniProject208
{
    public class CatatanRepo
    {
        // Get Data Catatan
        public static List<VMCatatan> GetData(long PelamarId)
        {
            List<VMCatatan> list = new List<VMCatatan>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                list = (from catatan in db.x_catatan.Where(a => a.is_delete == false)
                        join noteType in db.x_note_type on catatan.note_type_id equals noteType.id
                        join biodata in db.x_biodata on catatan.created_by equals biodata.id
                        where catatan.biodata_id == PelamarId

                        select new VMCatatan
                        {
                            id = catatan.id,
                            title = catatan.title,
                            note_type = noteType.name,
                            notes = catatan.notes,
                            biodata_id = catatan.biodata_id,
                            creator = biodata.fullname
                        }
                        ).ToList();
            }
            return list;
        }

        // Get Data Tipe Catatan (Select Options)
        public static List<VMNoteType> GetNoteType()
        {
            List<VMNoteType> list = new List<VMNoteType>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                list = (from noteType in db.x_note_type.Where(a => a.is_delete == false)

                        select new VMNoteType
                        {
                            id = noteType.id,
                            name = noteType.name,
                            created_by = noteType.created_by
                        }
                        ).ToList();
            }
            return list;
        }

        // Save Data Catatan
        public static bool CreateData(x_catatan data, long CreatorId)
        {
            try
            {
                using (DBMiniProject208Entities db = new DBMiniProject208Entities())
                {
                    data.created_by = CreatorId;
                    data.created_on = System.DateTime.Now;
                    data.is_delete = false;
                    db.x_catatan.Add(data);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        // Delete Data Catatan
        public static bool DeleteData(int Kode)
        {
            try
            {
                x_catatan data = new x_catatan();
                using (DBMiniProject208Entities db = new DBMiniProject208Entities())
                {
                    data = db.x_catatan.Where(a => a.id == Kode).FirstOrDefault();
                    data.is_delete = true;

                    db.Entry(data).State = EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // GET Data By ID (Edit)
        public static x_catatan GetDataById(Int64 id)
        {
            x_catatan data = new x_catatan();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                data = db.x_catatan.Find(id);// find database on id
            }
            return data;
        }

        // Edit Data Catatan
        public static bool EditData(x_catatan data)
        {
            try
            {
                using (DBMiniProject208Entities db = new DBMiniProject208Entities())
                {
                    x_catatan dataOld = db.x_catatan.Where(a => a.id == data.id).FirstOrDefault();
                    dataOld.title = data.title;
                    dataOld.notes = data.notes;
                    dataOld.note_type_id = data.note_type_id;
                    dataOld.modified_by = 1;
                    dataOld.modified_on = System.DateTime.Now;

                    db.Entry(dataOld).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
    }
}
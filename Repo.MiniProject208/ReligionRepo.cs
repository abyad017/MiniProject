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
    public class ReligionRepo
    {
        // Get Data Religion
        public static List<VMReligion> GetData()
        {
            List<VMReligion> list = new List<VMReligion>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                list = (from religion in db.x_religion.Where(a => a.is_delete == false)

                        select new VMReligion
                        {
                            id = religion.id,
                            name = religion.name,
                            description = religion.description
                        }
                        ).ToList();
            }
            return list;
        }

        // Create Data Religion
        public static void CreateData(x_religion data)
        {
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                data.created_by = 1;
                data.created_on = System.DateTime.Now;
                data.is_delete = false;
                db.x_religion.Add(data);
                db.SaveChanges();
            }
        }

        // Delete Data Religion
        public static bool DeleteData(int Kode)
        {
            try
            {
                x_religion data = new x_religion();
                using (DBMiniProject208Entities db = new DBMiniProject208Entities())
                {
                    data = db.x_religion.Where(a => a.id == Kode).FirstOrDefault();
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

        // GET Data By ID (Edit) Religion
        public static x_religion GetDataById(Int64 id)
        {
            x_religion data = new x_religion();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                data = db.x_religion.Find(id);// find database on id
            }
            return data;
        }

        // Edit Data Religion
        public static bool EditData(x_religion data)
        {
            try
            {
                using (DBMiniProject208Entities db = new DBMiniProject208Entities())
                {
                    x_religion dataOld = db.x_religion.Where(a => a.id == data.id).FirstOrDefault();
                    dataOld.name = data.name;
                    dataOld.description = data.description;
                    dataOld.modified_by = 1;
                    dataOld.modified_on = System.DateTime.Now;

                    db.Entry(dataOld).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Search Data Religion
        public static List<VMReligion> SearchData(string cari)
        {
            string CariData = cari;
            List<VMReligion> list = new List<VMReligion>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                list = (from religion in db.x_religion.Where(a => a.is_delete == false)
                        where religion.name.Contains(CariData)
                        //where religion.name == CariData

                        select new VMReligion
                        {
                            id = religion.id,
                            name = religion.name,
                            description = religion.description
                        }
                        ).ToList();
            }
            return list;
        }

        // Order Data By Asc
        public static List<VMReligion> OrderByAsc()
        {
            List<VMReligion> list = new List<VMReligion>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                list = (from religion in db.x_religion.Where(a => a.is_delete == false).OrderBy(a => a.name)

                        select new VMReligion
                        {
                            id = religion.id,
                            name = religion.name,
                            description = religion.description
                        }
                        ).ToList();
            }
            return list;
        }

        // Order Data By Desc
        public static List<VMReligion> OrderByDesc()
        {
            List<VMReligion> list = new List<VMReligion>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                list = (from religion in db.x_religion.Where(
                           a => a.is_delete == false
                       ).OrderByDescending(a => a.name)

                        select new VMReligion
                        {
                            id = religion.id,
                            name = religion.name,
                            description = religion.description
                        }
                        ).ToList();
            }
            return list;
        }

        // Row Per Page
        public static List<VMReligion> Row(int row)
        {
            List<VMReligion> list = new List<VMReligion>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                list = (from religion in db.x_religion.Where(
                           a => a.is_delete == false
                       ).Take(row)

                        select new VMReligion
                        {
                            id = religion.id,
                            name = religion.name,
                            description = religion.description
                        }
                        ).ToList();
            }
            return list;
        }
    }
}
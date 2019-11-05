using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.MiniProject208;

namespace Repo.MiniProject208
{
    public class SumberLokerRepo
    {
        public static List<x_sumber_loker> getAll()
        {
            List<x_sumber_loker> list = new List<x_sumber_loker>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                list = db.x_sumber_loker.Where(a => a.is_delete == false).ToList();
            }
            return list;
        }
        public static void saveAll(x_sumber_loker loker)
        {
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                //try
                //{
                loker.is_delete = false;
                loker.created_by = 1;
                loker.created_on = System.DateTime.Now;
                loker.biodata_id = 1;
                db.x_sumber_loker.Add(loker);
                db.SaveChanges();

                //}
                //catch (Exception e)
                //{

                //    throw;
                //}
            }
        }
    }
}

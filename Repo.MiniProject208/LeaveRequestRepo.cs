using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.MiniProject208;
using System.Data.Entity;
using ViewModel.MiniProject208;

namespace Repo.MiniProject208
{
    public class LeaveRequestRepo
    {
        public static List<VMLeaveRequest> getAll()
        {
            List<VMLeaveRequest> listlvr = new List<VMLeaveRequest>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                listlvr = (from lvr in db.x_leave_request
                           join lvn in db.x_leave_name on lvr.leave_name_id equals lvn.id
                           where lvr.is_delete == false
                           select new VMLeaveRequest
                           {
                               leave_name_id = lvr.leave_name_id,
                               start = lvr.start,
                               end_ = lvr.end_,
                               reason = lvr.reason,
                               leave_contact = lvr.leave_contact,
                               leave_address = lvr.leave_address,
                               leave_type = lvn.leave_type,
                               notes = lvn.notes,
                               name = lvn.name,
                               id = lvn.id,
                               id_tabel_req =lvr.id
                           }).ToList();

            }
            return listlvr;
        }

        public static List<VMLeaveRequest> getAll(long leaveid)
        {
            List<VMLeaveRequest> listlvr = new List<VMLeaveRequest>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                listlvr = (from lvr in db.x_leave_request
                           join lvn in db.x_leave_name on lvr.leave_name_id equals lvn.id
                           where lvr.is_delete == false
                           select new VMLeaveRequest
                           {
                               leave_name_id = lvr.leave_name_id,
                               start = lvr.start,
                               end_ = lvr.end_,
                               reason = lvr.reason,
                               leave_contact = lvr.leave_contact,
                               leave_address = lvr.leave_address,
                               leave_type = lvn.leave_type,
                               notes = lvn.notes,
                               name = lvn.name,
                               id = lvn.id,
                               id_tabel_req = lvr.id
                           }).ToList();

            }
            return listlvr;
        }
        public static List<x_leave_name> getdataleave()
        {
            List<x_leave_name> list = new List<x_leave_name>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                list = db.x_leave_name.GroupBy(a => a.leave_type).Select(b => b.FirstOrDefault()).ToList();
               //list = db.x_leave_name.ToList();
            }
            return list;
        }

        public static List<x_leave_name> getnamacuti(string name)
        {
            List<x_leave_name> list1 = new List<x_leave_name>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                list1 = db.x_leave_name.Where(a => a.leave_type.Equals(name)).ToList();
                //list = db.x_leave_name.ToList();
            }
            return list1;
        }
        public static void saveAll(x_leave_request lvr)
        {
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
         
                    try
                    {
                        // plt.biodata_id = 
                        lvr.created_by = 1;
                        lvr.created_on = System.DateTime.Now;
                        lvr.is_delete = false;
                        db.x_leave_request.Add(lvr);
                        db.SaveChanges();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                
        }
        public static List<x_leave_name> Search(string Key)
        {
            List<x_leave_name> list = new List<x_leave_name>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                list = db.x_leave_name.Where(
                    a => a.is_delete == false &&
                    a.leave_type.Contains(Key)
                    ).ToList();//store data to list
            }
            return list;
        }
        
        public static VMLeaveRequest getDataByID(long leave_name_id)
        {
            VMLeaveRequest dt = new VMLeaveRequest();

            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                dt = (from lvr in db.x_leave_request
                      join lvn in db.x_leave_name on lvr.leave_name_id equals lvn.id
                      where lvr.is_delete == false && lvr.leave_name_id == leave_name_id
                      select new VMLeaveRequest
                      {
                          leave_name_id = lvr.leave_name_id,
                          start = lvr.start,
                          end_ = lvr.end_,
                          reason = lvr.reason,
                          leave_contact = lvr.leave_contact,
                          leave_address = lvr.leave_address,
                          leave_type = lvn.leave_type,
                          notes = lvn.notes,
                          name = lvn.name,
                          id = lvn.id
                      }).FirstOrDefault();
                
            }
            return dt;
        }

     
        public static bool SimpanEdit(x_leave_request lvredit)
        {
            try
            {
                using (DBMiniProject208Entities db = new DBMiniProject208Entities())
                {
                    //VMLeaveRequest lvrdb = db.x_leave_request.Where(a =>a.id);
                    x_leave_request lvrdb = db.x_leave_request.Find(lvredit.id);
                    lvrdb.leave_name_id = lvredit.leave_name_id;
                    lvrdb.start = lvredit.start;
                    lvrdb.end_ = lvredit.end_;
                    lvrdb.reason = lvredit.reason;
                    lvrdb.leave_contact = lvredit.leave_contact;
                    lvrdb.leave_address = lvredit.leave_address;
                    lvrdb.modified_by = 1;   //biodata_id
                    lvrdb.modified_on = System.DateTime.Now;
                    db.Entry(lvrdb).State = EntityState.Modified;
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

        public static bool Deleted(long delid3)
        {
            try
            {
                
                using (DBMiniProject208Entities db = new DBMiniProject208Entities())
                {
                    x_leave_request dtleaveFromDb = new x_leave_request();
                    dtleaveFromDb = db.x_leave_request.Where(a => a.id == delid3).FirstOrDefault();
                    dtleaveFromDb.is_delete = true;
                    dtleaveFromDb.deleted_by = 1;
                    dtleaveFromDb.deleted_on = System.DateTime.Now;
                    db.Entry(dtleaveFromDb).State = EntityState.Modified;
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


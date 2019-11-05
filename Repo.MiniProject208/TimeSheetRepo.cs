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
    public class TimeSheetRepo
    {
        public static List<VMTimesheet> getData()
        {
            List<VMTimesheet> data = new List<VMTimesheet>();

            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                data = (from t in db.x_timesheet
                        join p in db.x_placement on t.placement_id equals p.id
                        join c in db.x_client on p.client_id equals c.id
                        where t.is_delete== false
                        orderby t.timesheet_date
                        select new VMTimesheet
                        {
                            timesheet_id = t.id,
                            status = t.status,
                            timesheet_date = t.timesheet_date,                           
                            name = c.name,
                            start = t.start,
                            start_ot = t.start_ot,
                            //end = t.end,
                            end_ot = t.end_ot,
                            activity = t.activity,
                            user_approval = t.user_approval,
                            ero_status = t.ero_status,
                            created_by = t.created_by,
                            created_on = t.created_on,
                            modified_by = t.modified_by,
                            modified_on = t.modified_on,
                            is_delete = t.is_delete,
                            approved_on = t.approved_on,
                            sent_on = t.sent_on,
                            collected_on = t.collected_on,
                            submitted_on = t.submitted_on

                        }
                    ).ToList();
            }
            return data;
        }
        public static VMTimesheet getDataEdit(long id)
        {
            VMTimesheet data = new VMTimesheet();

            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                data = (from t in db.x_timesheet
                        join p in db.x_placement on t.placement_id equals p.id
                        join c in db.x_client on p.client_id equals c.id
                        where t.id == id
                        orderby t.timesheet_date
                        select new VMTimesheet
                        {
                            timesheet_id = t.id,
                            status = t.status,
                            timesheet_date = t.timesheet_date,
                            name = c.name,
                            start = t.start,
                            start_ot = t.start_ot,
                            //end = t.end,
                            end_ot = t.end_ot,
                            activity = t.activity,
                            user_approval = t.user_approval,
                            ero_status = t.ero_status,
                            created_by = t.created_by,
                            created_on = t.created_on,
                            modified_by = t.modified_by,
                            modified_on = t.modified_on,
                            is_delete = t.is_delete,
                            approved_on = t.approved_on,
                            sent_on = t.sent_on,
                            collected_on = t.collected_on,
                            submitted_on = t.submitted_on
                        }
                    ).FirstOrDefault();
            }
            return data;
        }
        public static List<VMTimesheet> getClient()
        {
            List<VMTimesheet> data = new List<VMTimesheet>();

            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                data = (from c in db.x_client
                        join p in db.x_placement on c.id equals p.client_id
                        where p.is_placement_active == true
                        orderby c.id

                        select new VMTimesheet
                        {
                            placement_id = p.id,
                            name = c.name
                        }).ToList();
            }
            return data;
        }
        public static x_timesheet Save(x_timesheet data)
        {
            
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                try
                {
                    db.x_timesheet.Add(data);// insert into DB
                    db.SaveChanges();// save syntax
                }
                catch (Exception)
                {
                    throw;
                }
                
            }
            return data;
        }
        public static VMTimesheet getDetail(long id)
        {
            VMTimesheet data = new VMTimesheet();

            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                data = (from t in db.x_timesheet
                        join p in db.x_placement on t.placement_id equals p.id
                        join c in db.x_client on p.client_id equals c.id
                        where t.id == id && t.is_delete == false
                        orderby t.timesheet_date
                        select new VMTimesheet
                        {
                            timesheet_id = t.id,
                            status = t.status, overtime=t.overtime,
                            timesheet_date = t.timesheet_date,
                            name = c.name,
                            start= t.start, start_ot=t.start_ot,
                            //end=t.end,
                            end_ot =t.end_ot, activity=t.activity,
                            user_approval = t.user_approval,
                            ero_status = t.ero_status,
                            created_by = t.created_by,
                            created_on = t.created_on,
                            modified_by = t.modified_by,
                            modified_on = t.modified_on,
                            is_delete = t.is_delete,
                            approved_on = t.approved_on,
                            sent_on = t.sent_on,
                            collected_on = t.collected_on,
                            submitted_on = t.submitted_on
                        }
                    ).FirstOrDefault();
            }
            return data;
        }

        public static List<VMTimesheet> Search(DateTime datef,DateTime datel)
        {
            List<VMTimesheet> data = new List<VMTimesheet>();

            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                data = (from t in db.x_timesheet
                        join p in db.x_placement on t.placement_id equals p.id
                        join c in db.x_client on p.client_id equals c.id
                        where t.timesheet_date >= datef && t.timesheet_date <= datel
                        orderby t.timesheet_date
                        select new VMTimesheet
                        {
                            status = t.status,
                            timesheet_date = t.timesheet_date,
                            name = c.name,
                            user_approval = t.user_approval,
                            ero_status = t.ero_status
                        }
                    ).ToList();
            }
            return data;
        }

        public static bool Update(x_timesheet timesheet)
        {
            try
            {
                using (DBMiniProject208Entities db = new DBMiniProject208Entities())
                {
                    db.Entry(timesheet).State = EntityState.Modified;//update data to DB Barang
                    db.SaveChanges();//save syntax
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
        public static List<VMTimesheet> sortData(string sort)
        {
            List<VMTimesheet> data = new List<VMTimesheet>();
            
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                if (sort=="Ascending")
                {
                    data = (from t in db.x_timesheet
                            join p in db.x_placement on t.placement_id equals p.id
                            join c in db.x_client on p.client_id equals c.id
                            orderby t.id ascending
                            select new VMTimesheet
                            {
                                status = t.status,
                                timesheet_date = t.timesheet_date,
                                name = c.name,
                                user_approval = t.user_approval,
                                ero_status = t.ero_status
                            }
                    ).ToList();
                }
                else
                {
                    data = (from t in db.x_timesheet
                            join p in db.x_placement on t.placement_id equals p.id
                            join c in db.x_client on p.client_id equals c.id
                            orderby t.id descending
                            select new VMTimesheet
                            {
                                status = t.status,
                                timesheet_date = t.timesheet_date,
                                name = c.name,
                                user_approval = t.user_approval,
                                ero_status = t.ero_status
                            }
                    ).ToList();
                }
                
            }
            return data;
        }

    }
}

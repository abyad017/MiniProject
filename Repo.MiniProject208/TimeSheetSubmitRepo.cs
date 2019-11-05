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
    public class TimeSheetSubmitRepo
    {
        public static List<VMTimesheet> SearchData(int tahun ,int bulan)
        {
            List<VMTimesheet> data = new List<VMTimesheet>();

            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                data = (from t in db.x_timesheet
                        join p in db.x_placement on t.placement_id equals p.id
                        join c in db.x_client on p.client_id equals c.id
                        where t.is_delete == false 
                            && t.timesheet_date.Month == bulan 
                            && t.timesheet_date.Year == tahun
                            && t.user_approval == null
                            && t.ero_status == null
                        orderby t.timesheet_date
                        select new VMTimesheet
                        {
                            timesheet_id = t.id,
                            status = t.status,
                            timesheet_date = t.timesheet_date,
                            name = c.name,
                            start = t.start,
                            start_ot = t.start_ot,
                            end = t.end,
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
        public static List<VMTimesheet> getDdata()
        {
            List<VMTimesheet> data = new List<VMTimesheet>();

            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                data = (from t in db.x_timesheet
                        join p in db.x_placement on t.placement_id equals p.id
                        join c in db.x_client on p.client_id equals c.id
                        where t.id == 4
                        orderby t.timesheet_date
                        select new VMTimesheet
                        {
                            timesheet_id = t.id,
                            status = t.status,
                            timesheet_date = t.timesheet_date,
                            name = c.name,
                            start = t.start,
                            start_ot = t.start_ot,
                            end = t.end,
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
    }
}

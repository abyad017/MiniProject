using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.MiniProject208;
using ViewModel.MiniProject208;
using System.Globalization;

namespace Repo.MiniProject208
{
    public class SendTSRepo
    {
        public static List<VMTimesheet> getAll()
        {
            List<VMTimesheet> list = new List<VMTimesheet>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                list = (from tm in db.x_timesheet
                        join pl in db.x_placement on tm.placement_id equals pl.id
                        join em in db.x_employee on pl.employee_id equals em.id
                        join cl in db.x_client on pl.client_id equals cl.id
                        join bio in db.x_biodata on em.biodata_id equals bio.id
                        where tm.user_approval == "Approved" && tm.ero_status == null && tm.is_delete == false
                        select new VMTimesheet
                        {
                            idTimeSheet = tm.id,
                            status = tm.status,
                            timesheet_date = tm.timesheet_date,
                            user_approval = tm.user_approval,
                            ero_status = tm.ero_status,
                            is_delete = tm.is_delete,
                            idPlacement = pl.id,
                            client_id = pl.client_id,
                            employee_id = pl.employee_id,
                            idClient = cl.id,
                            name = cl.name,
                            user_client_name = cl.user_client_name,
                            idEmplo = em.id,
                            ero_email = em.ero_email,
                            biodata_id = em.biodata_id,
                            idBio = bio.id
                        }).ToList();
            }
            return list;
        }
        public static List<VMTimesheet> getData()
        {
            List<VMTimesheet> data = new List<VMTimesheet>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                data = (from tm in db.x_timesheet
                        join pl in db.x_placement on tm.placement_id equals pl.id
                        join cl in db.x_client on pl.client_id equals cl.id
                        where tm.is_delete == false && tm.user_approval == "Approved"
                        && tm.ero_status == null
                        orderby tm.timesheet_date
                        select new VMTimesheet
                        {
                            idTimeSheet = tm.id,
                            status = tm.status,
                            timesheet_date = tm.timesheet_date,
                            name = cl.name,
                            start = tm.start,
                            start_ot = tm.start_ot,
                            end = tm.end,
                            end_ot = tm.end_ot,
                            activity = tm.activity,
                            user_approval = tm.user_approval,
                            ero_status = tm.ero_status,
                            created_by = tm.created_by,
                            created_on = tm.created_on,
                            modified_by = tm.modified_by,
                            modified_on = tm.modified_on,
                            is_delete = tm.is_delete,
                            approved_on = tm.approved_on,
                            sent_on = tm.sent_on,
                            collected_on = tm.collected_on,
                            submitted_on = tm.submitted_on
                        }).ToList();
            }
            return data;
        }

        public static List<VMTimesheet> searchData(int tahun, int bulan)
        {
            List<VMTimesheet> data = new List<VMTimesheet>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                data = (from tm in db.x_timesheet
                        join pl in db.x_placement on tm.placement_id equals pl.id
                        join cl in db.x_client on pl.client_id equals cl.id
                        where tm.is_delete == false && tm.timesheet_date.Month == bulan
                        && tm.timesheet_date.Year == tahun && tm.user_approval == "Approved"
                        && tm.ero_status == null
                        orderby tm.timesheet_date
                        select new VMTimesheet
                        {
                            idTimeSheet = tm.id,
                            status = tm.status,
                            timesheet_date = tm.timesheet_date,
                            name = cl.name,
                            start = tm.start,
                            start_ot = tm.start_ot,
                            ends = tm.end,
                            end_ot = tm.end_ot,
                            activity = tm.activity,
                            user_approval = tm.user_approval,
                            ero_status = tm.ero_status,
                            created_by = tm.created_by,
                            created_on = tm.created_on,
                            modified_by = tm.modified_by,
                            modified_on = tm.modified_on,
                            is_delete = tm.is_delete,
                            approved_on = tm.approved_on,
                            sent_on = tm.sent_on,
                            collected_on = tm.collected_on,
                            submitted_on = tm.submitted_on
                        }).ToList();
            } return data;
        }
        public static List<Pilihan> getBulan()
        {
            DateTime bulan = new DateTime(2000, 1, 1);
            List<Pilihan> list = new List<Pilihan>();
            for (int i = 1; i <= 12; i++)
            {
                Pilihan bln = new Pilihan();
                bln.value = i;
                bln.text = bulan.ToString("MMMM", CultureInfo.CreateSpecificCulture("id"));

                bulan = bulan.AddMonths(1);
                list.Add(bln);
            }
            return list;
        }
        public static List<Pilihan> getTahun()
        {
            DateTime tahun = new DateTime(2019, 1, 1);
            List<Pilihan> list = new List<Pilihan>();
            for (int i = 0; i <= 12; i++)
            {
                Pilihan thn = new Pilihan();
                thn.text = tahun.Year.ToString();
                list.Add(thn);
                tahun = tahun.AddYears(-1);
            }
            return list;
        }




    }
    public class Pilihan
    {
        public int value { get; set; }
        public string text { get; set; }
    }
}



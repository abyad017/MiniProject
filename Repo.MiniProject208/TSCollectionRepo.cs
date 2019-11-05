using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.MiniProject208;
using ViewModel.MiniProject208;

namespace Repo.MiniProject208
{
    public class TSCollectionRepo
    {
        public static List<VMTimesheet> getAll()
        {
            List<VMTimesheet> list = new List<VMTimesheet>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                list = (from tm in db.x_timesheet
                        join pl in db.x_placement on tm.placement_id equals pl.id
                        join cl in db.x_client on pl.client_id equals cl.id
                        join em in db.x_employee on pl.employee_id equals em.id
                        join bio in db.x_biodata on em.biodata_id equals bio.id
                        where tm.user_approval == "Approved" && tm.ero_status == "Sent" && tm.is_delete == false
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
                            submitted_on = tm.submitted_on,
                            idEmplo = em.id,
                            ero_email = em.ero_email,
                            biodata_id = em.biodata_id,
                            idBio = bio.id,
                            namaPgw = bio.fullname
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
                        join em in db.x_employee on pl.employee_id equals em.id
                        join bio in db.x_biodata on em.biodata_id equals bio.id
                        where tm.is_delete == false 
                        && tm.user_approval == "Approved"
                        && tm.ero_status == "Sent"
                        orderby tm.timesheet_date, cl.name, bio.fullname
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
                            submitted_on = tm.submitted_on,
                            idEmplo = em.id,
                            ero_email = em.ero_email,
                            biodata_id = em.biodata_id,
                            idBio = bio.id,
                            namaPgw = bio.fullname
                        }).ToList();
            }
            return data;
        }

        public static List<VMTimesheet> searchData(int tahun, int bulan, string namaPgw, string client)
        {
            List<VMTimesheet> data = new List<VMTimesheet>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                data = (from tm in db.x_timesheet
                        join pl in db.x_placement on tm.placement_id equals pl.id
                        join cl in db.x_client on pl.client_id equals cl.id
                        join em in db.x_employee on pl.employee_id equals em.id
                        join bio in db.x_biodata on em.biodata_id equals bio.id
                        where tm.is_delete == false && tm.timesheet_date.Month == bulan
                        && cl.name == client && bio.fullname == namaPgw
                        && tm.timesheet_date.Year == tahun && tm.user_approval == "Approved"
                        && tm.ero_status == "Sent"
                        orderby tm.timesheet_date, cl.name, bio.fullname
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
                            submitted_on = tm.submitted_on,
                            idEmplo = em.id,
                            ero_email = em.ero_email,
                            biodata_id = em.biodata_id,
                            idBio = bio.id,
                            namaPgw = bio.fullname
                        }).ToList();
            }
            return data;
        }

        public static List<x_biodata> getNamaPgw()
        {
            List<x_biodata> listNama = new List<x_biodata>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                listNama = db.x_biodata.ToList();
            }
            return listNama;
        }

        public static List<x_client> getClient()
        {
            List<x_client> listClient = new List<x_client>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                listClient = db.x_client.ToList();
            } return listClient;
        }
    }
}

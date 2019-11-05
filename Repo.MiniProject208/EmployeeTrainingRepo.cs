using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.MiniProject208;
using ViewModel.MiniProject208;

namespace Repo.MiniProject208
{
    public class EmployeeTrainingRepo
    {
        public static List <VMEmployeeTraining> getAll()
        {

            List<VMEmployeeTraining> list = new List<VMEmployeeTraining>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                list = (from et in db.x_employee_training.Where(a => a.is_delete == false)
                        join bio in db.x_biodata on et.employee_id equals bio.id
                        join tra in db.x_training on et.training_id equals tra.id
                        join to in db.x_training_organizer on et.training_organizer_id equals to.id
                        select new VMEmployeeTraining
                        {
                            id =et.id, 
                            employee_id = et.employee_id,
                            fullname = bio.fullname,
                            name_trai = tra.name,
                            training_date = et.training_date,
                            name_to = to.name,
                            status = et.status
                        }).ToList();
            }
            return list;
        }

        public static void saveAll(x_employee_training emtraining)
        {
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                emtraining.is_delete = false;
                emtraining.status = "Submitted";
                emtraining.created_by = 1;
                emtraining.created_on = System.DateTime.Now;
                db.x_employee_training.Add(emtraining);
                db.SaveChanges();

            }
        }

        public static x_employee_training getDatabyId(long id)
        {
            x_employee_training dt = new x_employee_training();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                dt = db.x_employee_training.Find(id);// find data base on id
            }
            return dt;
        }

        public static bool Edit(x_employee_training emtraining_edit)
        {
            try
            {

                using (DBMiniProject208Entities db = new DBMiniProject208Entities())
                {
                    x_employee_training data_old = getDatabyId(emtraining_edit.id);
                    data_old.id = emtraining_edit.id;
                    data_old.employee_id = emtraining_edit.employee_id;
                    data_old.training_id = emtraining_edit.training_id;
                    data_old.training_organizer_id = emtraining_edit.training_organizer_id;
                    data_old.training_date = emtraining_edit.training_date;
                    data_old.training_type_id = emtraining_edit.training_type_id;
                    data_old.certification_type_id = emtraining_edit.certification_type_id;
                    data_old.status = emtraining_edit.status;
                    data_old.modified_by = 1;
                    data_old.modified_on = System.DateTime.Now;

                    db.Entry(data_old).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        //awal bagian viewbag dropdown
        public static List<x_biodata> getbiodata()
        {
            List<x_biodata> lstbiodata = new List<x_biodata>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                lstbiodata = db.x_biodata.Where(a => a.is_delete == false).ToList();
            }
            return lstbiodata;
        }

        public static List<x_training> gettraining()
        {
            List<x_training> lsttraining = new List<x_training>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                lsttraining = db.x_training.Where(a => a.is_delete == false).ToList();
            }
            return lsttraining;
        }

        public static List<x_training_organizer> gettrainingorganizer()
        {
            List<x_training_organizer> lstorganizer = new List<x_training_organizer>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                lstorganizer = db.x_training_organizer.Where(a => a.is_delete == false).ToList();
            }
            return lstorganizer;
        }

        public static List<x_training_type> gettrainingtype()
        {
            List<x_training_type> lsttype = new List<x_training_type>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                lsttype = db.x_training_type.Where(a => a.is_delete == false).ToList();
            }
            return lsttype;
        }

        public static List<x_certification_type> getcertificationtype()
        {
            List<x_certification_type> lstcertification = new List<x_certification_type>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                lstcertification = db.x_certification_type.Where(a => a.is_delete == false).ToList();
            }
            return lstcertification;
        }

        //akhir bagian viewbag dropdown

        public static bool hapus(long id_employee)
        {
            try
            {
                x_employee_training employee = new x_employee_training();
                using (DBMiniProject208Entities db = new DBMiniProject208Entities())
                {
                    employee = db.x_employee_training.Where(a => a.id == id_employee).FirstOrDefault();
                    employee.is_delete = true;
                    employee.deleted_by = 1;
                    employee.deleted_on = System.DateTime.Now;

                    db.Entry(employee).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool hapus2(long id_employee)
        {
            try
            {
                x_employee_training employee = new x_employee_training();
                using (DBMiniProject208Entities db = new DBMiniProject208Entities())
                {
                    employee = db.x_employee_training.Where(a => a.id == id_employee).FirstOrDefault();
                    employee.status = "Approve";

                    db.Entry(employee).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool hapus3(long id_employee)
        {
            try
            {
                x_employee_training employee = new x_employee_training();
                using (DBMiniProject208Entities db = new DBMiniProject208Entities())
                {
                    employee = db.x_employee_training.Where(a => a.id == id_employee).FirstOrDefault();
                    employee.status = "Rejected";

                    db.Entry(employee).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool hapus4(long id_employee)
        {
            try
            {
                x_employee_training employee = new x_employee_training();
                using (DBMiniProject208Entities db = new DBMiniProject208Entities())
                {
                    employee = db.x_employee_training.Where(a => a.id == id_employee).FirstOrDefault();
                    employee.status = "Done";

                    db.Entry(employee).State = System.Data.Entity.EntityState.Modified;
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

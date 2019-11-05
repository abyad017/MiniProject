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
    public class ProsesPelamarRepo
    {
        public static List<VMPelamar> GetData()
        {
            List<VMPelamar> list = new List<VMPelamar>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                list = (from pelamar in db.x_biodata
                        join pendidikan in db.x_riwayat_pendidikan
                        on pelamar.id equals pendidikan.biodata_id
                        where pelamar.is_complete == false 

                        select new VMPelamar
                        {
                            id = pelamar.id,
                            fullname = pelamar.fullname,
                            school_name = pendidikan.school_name,
                            major = pendidikan.major,
                            
                            is_complete = pelamar.is_complete,
                            is_process = pelamar.is_process,
                            is_delete = pelamar.is_delete
                        }).ToList();
            }
            return list;
        }

        // Proses Pelamar
        public static bool ProsesData(int Kode)
        {
            try
            {
                x_biodata data = new x_biodata();
                using (DBMiniProject208Entities db = new DBMiniProject208Entities())
                {
                    data = db.x_biodata.Where(a => a.id == Kode).FirstOrDefault();
                    data.is_process = true;

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

        public static List<VMDetailRencanaJadwal> GetDataPenjadwalan()
        {
            List<VMDetailRencanaJadwal> list = new List<VMDetailRencanaJadwal>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                list = ( from b in db.x_biodata

                         join jd in db.x_rencana_jadwal_detail
                         on b.id equals jd.biodata_id

                         join j in db.x_rencana_jadwal
                         on jd.id equals j.id
                         
                         join jt in db.x_schedule_type
                         on j.schedule_type_id equals jt.id
                         
                         //join ud in db.x_undangan_detail
                         //on b.id equals ud.biodata_id

                         //join u in db.x_undangan
                         //on ud.id equals u.id

                         //join ut in db.x_schedule_type
                         //on u.schedule_type_id equals ut.id

                         //join t in db.x_schedule_type
                         //on j.schedule_type_id equals t.id

                         //from j in db.x_rencana_jadwal
                         //from t in db.x_schedule_type
                         //from b in db.x_biodata

                         //where
                         //    j.schedule_type_id == t.id
                         //&&
                         //    (j.ro == b.id || j.tro == b.id)
                         //&&
                         //    j.is_delete == false

                         select new VMDetailRencanaJadwal
                        {
                            p_id = j.id,
                            p_schedule_date = j.schedule_date,
                            p_time = j.time,
                            p_location = j.location,
                            p_ro = j.ro,
                            p_tro = j.tro,
                            p_schedule_type = jt.name,
                            p_is_delete = j.is_delete,

                            //u_id = u.id,
                            //u_invitation_date = u.invitation_date,
                            //u_time = u.time,
                            //u_location = u.location,
                            //u_ro = u.ro,
                            //u_tro = u.tro,
                            //u_schedule_type = ut.name,
                            //u_is_delete = u.is_delete,
                        }).ToList();
            }
            return list;
        }
    }
}

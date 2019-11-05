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
    public class PelamarRepo
    {
        // GET: Data Pelamar
        public static List<VMPelamar> GetData()
        {
            List<VMPelamar> list = new List<VMPelamar>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                list = (from pelamar in db.x_biodata
                        join pendidikan in db.x_riwayat_pendidikan
                        on pelamar.id equals pendidikan.biodata_id

                        select new VMPelamar
                        {
                            id = pelamar.id,
                            fullname = pelamar.fullname,
                            nick_name = pelamar.nick_name,
                            email = pelamar.email,
                            phone_number1 = pelamar.phone_number1,
                            school_name = pendidikan.school_name,
                            major = pendidikan.major
                        }).ToList();
            }
            return list;
        }

        // Search Data Pelamar
        public static List<VMPelamar> SearchData(string KeyWord)
        {
            List<VMPelamar> list = new List<VMPelamar>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                list = (from pelamar in db.x_biodata
                        join pendidikan in db.x_riwayat_pendidikan
                        on pelamar.id equals pendidikan.biodata_id
                        where pelamar.fullname.Contains(KeyWord)

                        select new VMPelamar
                        {
                            id = pelamar.id,
                            fullname = pelamar.fullname,
                            nick_name = pelamar.nick_name,
                            email = pelamar.email,
                            phone_number1 = pelamar.phone_number1,
                            school_name = pendidikan.school_name,
                            major = pendidikan.major
                        }).ToList();

            }
            return list;
        }

        // GET: Data Religion
        public static List<x_religion> GetReligion()
        {
            List<x_religion> list = new List<x_religion>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                list = db.x_religion.ToList();
            }
            return list;
        }

        //GET: Data Identity
        public static List<x_identity_type> GetIdentity()
        {
            List<x_identity_type> list = new List<x_identity_type>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                list = db.x_identity_type.ToList();
            }
            return list;
        }

        // GET: Data Marital
        public static List<x_marital_status> GetMarital()
        {
            List<x_marital_status> list = new List<x_marital_status>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                list = db.x_marital_status.ToList();
            }
            return list;
        }

        // Create Data Pelamar
        public static bool CreateData(VMPelamar data)
        {

            x_biodata biodata = new x_biodata();
            x_address address = new x_address();

            biodata.fullname = data.fullname;
            biodata.nick_name = data.nick_name;
            biodata.pob = data.pob;
            biodata.dob = data.dob;
            biodata.gender = data.gender;
            biodata.religion_id = data.religion_id;
            biodata.high = data.high;
            biodata.weights = data.weights;
            biodata.nationality = data.nationality;
            biodata.ethnic = data.ethnic;
            biodata.hobby = data.hobby;
            biodata.identity_type_id = data.identity_type_id;
            biodata.identity_no = data.identity_no;
            biodata.email = data.email;
            biodata.phone_number1 = data.phone_number1;
            biodata.phone_number2 = data.phone_number2;
            biodata.parent_phone_number = data.parent_phone_number;
            biodata.child_sequence = data.child_sequence;
            biodata.how_many_brothers = data.how_many_brothers;
            biodata.marital_status_id = data.marital_status_id;
            biodata.marriage_year = data.marriage_year;

            address.biodata_id = GetBiodataById();
            address.address1 = data.address1;
            address.postal_code1 = data.postal_code1;
            address.rt1 = data.rt1;
            address.rw1 = data.rw1;
            address.kelurahan1 = data.kelurahan1;
            address.kecamatan1 = data.kecamatan1;
            address.region1 = data.region1;
            address.address2 = data.address2;
            address.postal_code2 = data.postal_code2;
            address.rt2 = data.rt2;
            address.rw2 = data.rw2;
            address.kelurahan2 = data.kelurahan2;
            address.kecamatan2 = data.kecamatan2;
            address.region2 = data.region2;

            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
                try
                {
                    biodata.company_id = 1;
                    db.x_biodata.Add(biodata);
                    db.x_address.Add(address);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return false;
                }
        }

        // Get Data By ID (Biodata/Pelamar)
        public static x_biodata GetDataById(int id)
        {
            x_biodata data = new x_biodata();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                data = db.x_biodata.Find(id);
            }
            return data;
        }

        // Get Id Biodata (Pelamar) for Address
        public static long GetBiodataById()
        {
            x_biodata data = new x_biodata();
            long id = new long();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                data = db.x_biodata.OrderByDescending(a => a.id).FirstOrDefault();
            }
            if (data != null)
            {
                id = data.id + 1;
            }
            else
            {
                id = 1;
            }
            return id;
        }

        // GET: Data Email (Validasi)
        public static bool CheckExistEmail(string email)
        {
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                x_biodata pelamar = db.x_biodata.Where(a => a.email.Contains(email)).FirstOrDefault();
                if (pelamar != null)
                {
                    return true;
                }
            }
            return false;
        }

        // GET: Data No HP (Validasi)
        public static bool CheckExistNoHP(string NoHP)
        {
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                x_biodata pelamar = db.x_biodata.Where(a => a.phone_number1.Contains(NoHP)).FirstOrDefault();
                if (pelamar != null)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
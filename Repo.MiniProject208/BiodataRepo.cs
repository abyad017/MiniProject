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
    public class BiodataRepo
    {
        public static VMBiodata getAll()
        {
            VMBiodata list = new VMBiodata();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                list = (from bio in db.x_biodata
                        join addr in db.x_address on bio.id equals addr.biodata_id
                        join ident in db.x_identity_type on bio.identity_type_id equals ident.id
                        join agama in db.x_religion on bio.religion_id equals agama.id
                        join marital in db.x_marital_status on bio.marital_status_id equals marital.id

                        select new VMBiodata
                        {
                            idBio = bio.id,
                            fullname = bio.fullname,
                            nick_name = bio.nick_name,
                            pob = bio.pob,
                            dob = bio.dob,
                            gender = bio.gender,
                            religion_id = agama.id,
                            NamaAgama = agama.name,
                            high = bio.high,
                            weights = bio.weights,
                            nationality = bio.nationality,
                            ethnic = bio.ethnic,
                            hobby = bio.hobby,
                            identity_type_id = ident.id,
                            identityName = ident.name,
                            identity_no = bio.identity_no,
                            email = bio.email,
                            phone_number1 = bio.phone_number1,
                            phone_number2 = bio.phone_number2,
                            parent_phone_number = bio.parent_phone_number,
                            child_sequence = bio.child_sequence,
                            how_many_brothers = bio.how_many_brothers,
                            marital_status_id = marital.id,
                            status = marital.name,
                            address1 = addr.address1,
                            address2 = addr.address2,
                            postal_code1 = addr.postal_code1,
                            postal_code2 = addr.postal_code2,
                            rt1 = addr.rt1,
                            rt2 = addr.rt2,
                            rw1 = addr.rw1,
                            rw2 = addr.rw2,
                            kelurahan1 = addr.kelurahan1,
                            kelurahan2 = addr.kelurahan2,
                            kecamatan1 = addr.kecamatan1,
                            kecamatan2 = addr.kecamatan2,
                            region1 = addr.region1,
                            region2 = addr.region2
                        }).FirstOrDefault();
            }
            return list;
        }

        public static VMBiodata getDataByID(long num)
        {


            VMBiodata list = new VMBiodata();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                list = (from bio in db.x_biodata
                        join addr in db.x_address on bio.id equals addr.biodata_id
                        join ident in db.x_identity_type on bio.identity_type_id equals ident.id
                        join agama in db.x_religion on bio.religion_id equals agama.id
                        join marital in db.x_marital_status on bio.marital_status_id equals marital.id
                        where bio.id == num
                        select new VMBiodata
                        {

                            idBio = bio.id,
                            fullname = bio.fullname,
                            nick_name = bio.nick_name,
                            pob = bio.pob,
                            dob = bio.dob,
                            gender = bio.gender,
                            religion_id = agama.id,
                            NamaAgama = agama.name,
                            high = bio.high,
                            weights = bio.weights,
                            nationality = bio.nationality,
                            ethnic = bio.ethnic,
                            hobby = bio.hobby,
                            identity_type_id = ident.id,
                            identityName = ident.name,
                            identity_no = bio.identity_no,
                            email = bio.email,
                            phone_number1 = bio.phone_number1,
                            phone_number2 = bio.phone_number2,
                            parent_phone_number = bio.parent_phone_number,
                            child_sequence = bio.child_sequence,
                            how_many_brothers = bio.how_many_brothers,
                            marital_status_id = marital.id,
                            status = marital.name,
                            address1 = addr.address1,
                            address2 = addr.address2,
                            postal_code1 = addr.postal_code1,
                            postal_code2 = addr.postal_code2,
                            rt1 = addr.rt1,
                            rt2 = addr.rt2,
                            rw1 = addr.rw1,
                            rw2 = addr.rw2,
                            kelurahan1 = addr.kelurahan1,
                            kelurahan2 = addr.kelurahan2,
                            kecamatan1 = addr.kecamatan1,
                            kecamatan2 = addr.kecamatan2,
                            region1 = addr.region1,
                            region2 = addr.region2
                        }).FirstOrDefault();

            }
            return list;

        }

        public static bool simpanEdit(VMBiodata biodata)
        {
            x_biodata bio = new x_biodata();
            x_address addr = new x_address();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                bio = db.x_biodata.Find(biodata.idBio);
                addr = db.x_address.Where(a => a.biodata_id == biodata.idBio).FirstOrDefault();
                
                bio.modified_on = System.DateTime.Now;
                bio.modified_by = 1;
                addr.modified_by = 1;
                addr.modified_on = System.DateTime.Now;
                bio.is_delete = false;
                addr.is_delete = false;
                bio.id = biodata.idBio;
                bio.fullname = biodata.fullname;
                bio.nick_name = biodata.nick_name;
                bio.pob = biodata.pob;
                bio.dob = biodata.dob;
                bio.gender = biodata.gender;
                bio.religion_id = biodata.idAgama;
                bio.high = biodata.high;
                bio.weights = biodata.weights;
                bio.nationality = biodata.nationality;
                bio.ethnic = biodata.ethnic;
                bio.identity_type_id = biodata.idIden;
                bio.identity_no = biodata.identity_no;
                bio.email = biodata.email;
                bio.phone_number1 = biodata.phone_number1;
                bio.phone_number2 = biodata.phone_number2;
                bio.parent_phone_number = biodata.parent_phone_number;
                bio.child_sequence = biodata.child_sequence;
                bio.how_many_brothers = biodata.how_many_brothers;
                bio.marital_status_id = biodata.idStatus;
                bio.marriage_year = biodata.marriage_year;
                addr.address1 = biodata.address1;
                addr.address2 = biodata.address2;
                addr.postal_code1 = biodata.postal_code1;
                addr.postal_code2 = biodata.postal_code2;
                addr.rt1 = biodata.rt1;
                addr.rt2 = biodata.rt2;
                addr.rw1 = biodata.rw1;
                addr.rw2 = biodata.rw2;
                addr.kelurahan1 = biodata.kelurahan1;
                addr.kelurahan2 = biodata.kelurahan2;
                addr.kecamatan1 = biodata.kecamatan1;
                addr.kecamatan2 = biodata.kecamatan2;
                addr.region1 = biodata.region1;
                addr.region2 = biodata.region2;

                try
                {
                    //bio.is_delete = false;
                    //addr.is_delete = false;

                    db.Entry(bio).State = EntityState.Modified;
                    db.Entry(addr).State = EntityState.Modified;
                    db.SaveChanges();
                    return true;

                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public static bool cekExistEmail (string Email)
        {
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                x_biodata bio = db.x_biodata.Where(a => a.email.Contains(Email)).FirstOrDefault();
                if(bio != null)
                {
                    return true;
                }
            } return false;
        }

        public static bool cekExistEmailID(string Email1, long idBio)
        {
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                x_biodata bio = db.x_biodata.Where(a => a.email.Contains(Email1) && a.id != idBio).FirstOrDefault();
                if (bio != null)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool cekEsxistNoHP (string NoHP)
        {
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                x_biodata bio = db.x_biodata.Where(a => a.phone_number1.Contains(NoHP)).FirstOrDefault();
                if(bio != null)
                {
                    return true;
                }
            } return false;
        }

        public static bool cekEsxistNoHPid(string NoHP, long idBio)
        {
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                x_biodata bio = db.x_biodata.Where(a => a.phone_number1.Contains(NoHP) && a.id != idBio).FirstOrDefault();
                if (bio != null)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool cekIdentitas(long idIden, long idBio, string noIden)
        {
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                x_biodata bio = db.x_biodata.Where(a => a.identity_no.Contains(noIden) && a.identity_type_id == idIden && a.id != idBio).FirstOrDefault();
                if(bio != null)
                {
                    return true;
                }
            } return false;
        }

        public static List<x_religion> getAgama()
        {
            List<x_religion> listAgama = new List<x_religion>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                listAgama = db.x_religion.ToList();
            }
            return listAgama;
        }

        public static List<x_marital_status> getMarital()
        {
            List<x_marital_status> listMarital = new List<x_marital_status>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                listMarital = db.x_marital_status.ToList();
            }
            return listMarital;
        }

        public static List<x_identity_type> getIden()
        {
            List<x_identity_type> listIden = new List<x_identity_type>();
            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                listIden = db.x_identity_type.ToList();
            }
            return listIden;
        }

        public static List<VMGender> getGender()
        {
            List<VMGender> gen = new List<VMGender>();
            VMGender gender1 = new VMGender();
            gender1.gender = true;
            gender1.ketGender = "Wanita";
            gen.Add(gender1);

            VMGender gender2 = new VMGender();
            gender2.gender = false;
            gender2.ketGender = "Pria";
            gen.Add(gender2);
            return gen;
        }

    }
    public class VMGender
    {
        public bool gender { get; set; }
        public string ketGender { get; set; }

    }


}

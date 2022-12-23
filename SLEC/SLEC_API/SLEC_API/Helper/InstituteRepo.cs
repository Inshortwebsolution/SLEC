using Newtonsoft.Json;
using SharedModel.Models;
using SLEC_API.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SLEC_API.Helper
{
    public class InstituteRepo : IInstituteRepo
    {
        IWSSLSEEntities db = new IWSSLSEEntities();

        public bool Delete(int id)
        {
            bool n = false;
            try
            {
                var item = db.IWS_Institute.Where(x => x.id == id).FirstOrDefault();
                item.isdeleted = true;
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
                n = true;
            }
            catch (Exception)
            {

                throw;
            }
            return n;
        }

        public List<Institute> GetAll()
        {
            List<Institute> lst = new List<Institute>();
            List<IWS_Institute> iwslst = new List<IWS_Institute>();
            iwslst = db.IWS_Institute.Where(x => x.isActive == true && x.isdeleted == false).ToList();
            string json = JsonConvert.SerializeObject(iwslst);
            lst = JsonConvert.DeserializeObject<List<Institute>>(json);
            return lst;
        }

        public Institute GetById(int id)
        {
            Institute inst = new Institute();
            IWS_Institute iwsinst = new IWS_Institute();
            iwsinst = db.IWS_Institute.Where(x => x.id == id && x.isActive == true && x.isdeleted == false).FirstOrDefault();
            string json = JsonConvert.SerializeObject(iwsinst);
            inst = JsonConvert.DeserializeObject<Institute>(json);
            return inst;
        }

        public bool Save(Institute inst)
        {
            bool result = false;
            try
            {
                string json = JsonConvert.SerializeObject(inst);
                IWS_Institute institute = JsonConvert.DeserializeObject<IWS_Institute>(json);
                institute.createdone = DateTime.Now;
                institute.isdeleted = false;
                institute.isActive = true;
                db.IWS_Institute.Add(institute);
                IWS_Login iWS_Login = new IWS_Login();
                //iWS_Login.UserName1 = inst.Email;
                iWS_Login.type = "Institute";
                Random obj = new Random();
                var id = obj.Next(100, 999);
                iWS_Login.userid = id;
                iWS_Login.password = "INSHORT" + id;
                iWS_Login.UserName = inst.Email;
                iWS_Login.isactive = true;
                iWS_Login.created_by = 1;
                iWS_Login.created_date = DateTime.Now;
                db.IWS_Login.Add(iWS_Login);

                db.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {

                throw;
            }
            return result;

        }

        public bool Update(Institute inst)
        {
            bool result = false;
            try
            {
                var item = db.IWS_Institute.Where(x => x.id == inst.id).FirstOrDefault();
                item.name = inst.name;
                item.mobile = inst.mobile;
                item.Email = inst.Email;
                item.Address = inst.Address;
                item.YourEducation = inst.YourEducation;
                item.Institute_type = inst.Institute_type;
                item.Present_job_profession = inst.Present_job_profession; 
                item.Education_Sector_Experience = inst.Education_Sector_Experience;
                item.Your_Comment_query = inst.Your_Comment_query;


                db.SaveChanges();
                result = true;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }


    }
}
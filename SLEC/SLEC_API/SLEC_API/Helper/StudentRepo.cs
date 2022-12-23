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
    public class StudentRepo : IStudentRepo
    {

       IWSSLSEEntities db = new IWSSLSEEntities();

        public bool Approve(int? id)
        {
            bool result = false;
            try
            {
                var item = db.IWS_Student.Where(x => x.id == id).FirstOrDefault();
                item.isApprove = true;
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
                result = true;
            }
            catch (Exception)
            {

                throw;
            }
            return result;

        }
    

        public bool Delete(int id)
        {
            bool n = false;
            try
            {
                var item = db.IWS_Student.Where(x => x.id == id).FirstOrDefault();
                item.isdeleted = true;

                db.SaveChanges();
                n = true;
            }
            catch (Exception)
            {

                throw;
            }
            return n;
        }

        public List<Student> GetAll()
        {
            List<Student> lst = new List<Student>();
            List<IWS_Student> iwslst = new List<IWS_Student>();
            iwslst = db.IWS_Student.Where(x => x.isactive == true && x.isdeleted == false).ToList();
            string json = JsonConvert.SerializeObject(iwslst);
            lst = JsonConvert.DeserializeObject<List<Student>>(json);
            return lst;
        }
           
        public Student GetById(int id)
        {
            Student student = new Student();
            IWS_Student iwsstudent = new IWS_Student();
            iwsstudent = db.IWS_Student.Where(x => x.id == id && x.isactive == true && x.isdeleted == false).FirstOrDefault();
            string json = JsonConvert.SerializeObject(iwsstudent);
            student = JsonConvert.DeserializeObject<Student>(json);
            return student;
        }

        public bool SaveStudent(IWS_Student student)
        {
            bool result = false;
            try
            {
                string json = JsonConvert.SerializeObject(student);
                IWS_Student iWS_Student = JsonConvert.DeserializeObject<IWS_Student>(json);
                iWS_Student.isactive = true;
                iWS_Student.isdeleted = false;
                iWS_Student.created_date = DateTime.Now;
                db.IWS_Student.Add(iWS_Student);
                IWS_Login iWS_Login = new IWS_Login();
                //iWS_Login.UserName1 = student.email;
                iWS_Login.type = "Student";
                Random obj = new Random();
                var id = obj.Next(100, 9999);
                iWS_Login.userid = id;
                iWS_Login.password = "INSHORT" + id;
                iWS_Login.isactive = false;
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

        public bool Update(Student student)
        {
            bool result = false;
            try
            {
                var item = db.IWS_Student.Where(x => x.id == student.id).FirstOrDefault();
                item.name = student.name;
                item.f_name = student.f_name;
                item.m_name = student.m_name;
                item.lst_class = student.lst_class;
                item.dob = student.dob;
                item.course_name = student.course_name;
                item.cast = student.cast;
                item.religion = student.religion;
                item.address = student.address;
                item.aadhar_NO = student.aadhar_NO;
                item.whats_no_self = student.whats_no_self;
                item.whats_no_home = student.whats_no_home;
                item.email = student.email;
                item.refid = student.refid;
                db.SaveChanges();
                result = true;
            }
            catch (Exception)
            {

                throw;
            }
            return result;

        }

       

        public bool  WaitngApprovel(int? id)
        {
            bool results = false;
            try
            {
                var item = db.IWS_Student.Where(x => x.isOnline==true && x.isApprove==false).FirstOrDefault();
                db.SaveChanges();
                results=true;
            }
            catch (Exception)
            {
                 results=false;
            }
            return results;
            
        }
        public List<Student> GetAllApprovedStudent()
        {
            List<Student> lst = new List<Student>();
            List<IWS_Student> iwslst = new List<IWS_Student>();
            iwslst = db.IWS_Student.Where(x => x.isOnline == true && x.isApprove == true && x.isdeleted == false).ToList();
            string json = JsonConvert.SerializeObject(iwslst);
            lst = JsonConvert.DeserializeObject<List<Student>>(json);
            return lst;
        }

        public   bool SendWaitingForApprove(int id)
        {


            bool result = false;
            try
            {
                var item = db.IWS_Student.Where(x => x.id == id && x.isOnline==true && x.isApprove==false ).FirstOrDefault();
                item.isApprove = true;
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
                result = true;
            }
            catch (Exception)
            {

                throw;
            }
            return result;


        }

        public bool SendForApprove(int? id)
        {
            bool result = false;
            try
            {
                var item = db.IWS_Student.Where(x => x.id == id).FirstOrDefault();
                item.isOnline = true;
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
                result = true;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public Student GetDetailById(int id)
        {
            Student student = new Student();
            IWS_Student iwsstudent = new IWS_Student();
            iwsstudent = db.IWS_Student.Where(x => x.id == id && x.isactive == true && x.isdeleted == false).FirstOrDefault();
            string json = JsonConvert.SerializeObject(iwsstudent);
            student = JsonConvert.DeserializeObject<Student>(json);
            return student;
        }

        public Student GetDetailByNameYear(string name, string year)
        {
            Student student = new Student();
                IWS_Student iwsstudent = new IWS_Student();
                iwsstudent = db.IWS_Student.Where(x => x.name == name && x.Year == year && x.isactive == true && x.isdeleted == false).FirstOrDefault();
                string json = JsonConvert.SerializeObject(iwsstudent);
                student = JsonConvert.DeserializeObject<Student>(json);
               return student;
        }

        public bool UpdateStatus(int id,string status)
        {

            bool result = false;
            try
            {
                var item = db.IWS_Student.Where(x => x.id == id).FirstOrDefault();

                item.Status = status;
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
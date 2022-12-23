
using Newtonsoft.Json;
using SharedModel.Models;
using SLEC_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SLEC_API.Helper
{
    
    public class CourseRepo : ICourseRepo
    {
       IWSSLSEEntities db = new IWSSLSEEntities();

        public bool Delete(int id)
        {
            bool n = false;
            try
            {


                var item = db.IWS_Courses.Where(x => x.id == id).FirstOrDefault();
                item.isdeleted = true;

                db.SaveChanges();
                n = true;
            }
            catch (Exception ex)
            {

                throw;
            }
            return n;
        }

        public List<Course> GetAll()
        {
            List<Course> lst = new List<Course>();
            List<IWS_Courses> iwslst = new List<IWS_Courses>();
            iwslst = db.IWS_Courses.Where(x => x.isactive == true && x.isdeleted == false).ToList();
            string json = JsonConvert.SerializeObject(iwslst);
            lst = JsonConvert.DeserializeObject<List<Course>>(json);
            return lst;
        }

        public Course GetById(int id)
        {
            Course course = new Course();
            IWS_Courses iwscourse = new IWS_Courses();
            iwscourse = db.IWS_Courses.Where(x => x.id == id && x.isactive == true && x.isdeleted == false).FirstOrDefault();
            string json = JsonConvert.SerializeObject(iwscourse);
            course = JsonConvert.DeserializeObject<Course>(json);
            return course;
        }

        public bool SaveCourses(Course course)
        {
            bool result = false;
            try
            {
                string json = JsonConvert.SerializeObject(course);
                IWS_Courses Courses = JsonConvert.DeserializeObject<IWS_Courses>(json);
                Courses.isdeleted = false;
                Courses.isactive = true;
                
                db.IWS_Courses.Add(Courses);
                db.SaveChanges();
                result = true;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public bool Update(Course course)
        {
            bool result = false;
            try
            {
                var item = db.IWS_Courses.Where(x => x.id == course.id).FirstOrDefault();
                item.add_coures = course.add_coures;
                item.duration = course.duration;
                item.fees = course.fees;

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
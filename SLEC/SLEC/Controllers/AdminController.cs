using Newtonsoft.Json;
using SharedModel.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq; 
using System.Web;
using System.Web.Mvc;
using SLEC_API.Models;
using System.IO;


namespace SLEC.Controllers
{
    public class AdminController : Controller
    {

        string apiurl = ConfigurationManager.AppSettings["SLEC_APIurl"].ToString();

        ICommonAPI api = new CommonAPI();
        // GET: Admin

        public ActionResult Index()
        {
            return View();
        }


       
        public ActionResult Institute_Registration()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Institute_Registration(Institute institute)
        {

            Response responseToView = new Response();
            try
            {
                if (institute != null)
                {
                    string url = apiurl + "Institute/Save";
                    string updateurl = apiurl + "Institute/Update";
                    if (institute.id > 0)
                    {

                        institute.opdatedby = "sdk";
                        institute.updatedon = DateTime.Now;
                        institute.isActive = true;
                        institute.isdeleted = false;

                        Response responseResult = api.Post(updateurl, institute);
                        if (responseResult.status)
                        {
                            responseToView.status = true;
                            responseToView.data = responseResult.data;

                        }
                        else { responseToView.status = false; responseToView.error = responseResult.error; }
                    }
                    else
                    {
                        institute.opdatedby = "sdk";
                        institute.updatedon = DateTime.Now;
                        institute.isActive = true;
                        institute.isdeleted = false;

                        Response responseResult = api.Post(url, institute);
                        if (responseResult.status)
                        {
                            responseToView.status = true;
                            responseToView.data = responseResult.data;

                        }
                        else { responseToView.status = false; responseToView.error = responseResult.error; }
                    }

                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return View();

        }
        public JsonResult GetAll()
        {
            List<Institute> list = new List<Institute>();
            string url = apiurl + "Institute/GetAll";
            try
            {
                Response responseResult = api.Get(url);
                if (responseResult.status)
                {
                    list = JsonConvert.DeserializeObject<List<Institute>>(responseResult.data.ToString());
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Edit(int Id)
        {
            Institute obj = new Institute();
            string url = apiurl + "Institute/GetById?id=" + Id + "";
            try
            {
                Response responseResult = api.Get(url);
                if (responseResult.status)
                {
                    obj = JsonConvert.DeserializeObject<Institute>(responseResult.data.ToString());
                }

            }
            catch (Exception ex)
            {

                throw;
            }
            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Delete(int Id)
        {
            Response responseResult = new Response();
            Institute obj = new Institute();
            string url = apiurl + "Institute/Delete?id=" + Id + "";
            try
            {
                responseResult = api.Get(url);
               
            }
            catch (Exception ex)
            {
                throw;
            }

            return Json(responseResult, JsonRequestBehavior.AllowGet);
        }


        public ActionResult Course()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Course(Course course)
        {

            Response responseToView = new Response();
            try
            {
                if (course != null)
                {
                    string url = apiurl + "Course/SaveCourses";
                    string updateurl = apiurl + "Course/Update";

                    if (course.id > 0)
                    {
                        course.isactive = true;
                        course.isdeleted = false;

                        Response responseResult = api.Post(updateurl, course);
                        if (responseResult.status)
                        {
                            responseToView.status = true;
                            responseToView.data = responseResult.data;

                        }
                        else { responseToView.status = false; responseToView.error = responseResult.error; }
                    }
                    else
                    {
                        course.isactive = true;
                        course.isdeleted = false;

                        Response responseResult = api.Post(url, course);
                        if (responseResult.status)
                        {
                            responseToView.status = true;
                            responseToView.data = responseResult.data;

                        }
                        else { responseToView.status = false; responseToView.error = responseResult.error; }
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return View();

        }
        public JsonResult GetAllc()
        {
            List<Course> list = new List<Course>();
            string url = apiurl + "Course/GetAll";
            try
            {
                Response responseResult = api.Get(url);
                if (responseResult.status)
                {
                    list = JsonConvert.DeserializeObject<List<Course>>(responseResult.data.ToString());
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Editc(int Id)
        {
            Course obj = new Course();
            string url = apiurl + "Course/GetCourcesById?id=" + Id + "";
            try
            {
                Response responseResult = api.Get(url);
                if (responseResult.status)
                {
                    obj = JsonConvert.DeserializeObject<Course>(responseResult.data.ToString());
                }

            }
            catch (Exception ex)
            {

                throw;
            }
            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Deletec(int Id)
        {
            Response responseResult = new Response();
            string url = apiurl + "Course/Delete?id=" + Id + "";
            try
            {
                responseResult = api.Get(url);

            }
            catch (Exception ex)
            {
                throw;
            }

            return Json(responseResult, JsonRequestBehavior.AllowGet);
        }
         public ActionResult Student_Approvel()
        {
            return View();
        }
        public JsonResult Student_Approvelbyid(int Id)
        {
            Response responseResult = new Response();
            string url = apiurl + "Student/Approve?id=" + Id + "";
            try
            {
                responseResult = api.Get(url);

            }
            catch (Exception ex)
            {
                throw;
            }
            return Json(responseResult, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetAll_Approvel_Waiting_Student()
        {
            List<Student> list = new List<Student>();
            string url = apiurl + "Student/WaitingApprovel";
            try
            {
                Response responseResult = api.Get(url);
                if (responseResult.status)
                {
                    list = JsonConvert.DeserializeObject<List<Student>>(responseResult.data.ToString());
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return Json(list, JsonRequestBehavior.AllowGet);
        }

    }
}
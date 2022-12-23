using Newtonsoft.Json;
using SharedModel.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using SLEC_API.Models;
using System.Net;
using System.Net.Http;




namespace SLEC.Controllers
{
    public class InstituteController : Controller

    {
        string apiurl = ConfigurationManager.AppSettings["SLEC_APIurl"].ToString();
        IWSSLSEEntities db = new IWSSLSEEntities();
        ICommonAPI api = new CommonAPI();
        // GET: Institute

        [Authentication]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Student_Registration()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Student_Registration(Student student)
        {
            Response responseToView = new Response();
            try
            {
                if (student != null)
                {
                    string url = apiurl + "Student/SaveStudent";
                    string updateurl = apiurl + "Student/Update";

                    if (student.id > 0)
                    {

                        student.updated_by = 2;
                        student.updated_date = DateTime.Now;
                        student.isactive = true;
                        student.isdeleted = false;

                        Response responseResult = api.Post(updateurl, student);
                        if (responseResult.status)
                        {
                            responseToView.status = true;
                            responseToView.data = responseResult.data;

                        }
                        else { responseToView.status = false; responseToView.error = responseResult.error; }
                    }
                    else
                    {
                        student.created_by = 2;
                        student.created_date = DateTime.Now;
                        student.isactive = true;
                        student.isdeleted = false;

                        Response responseResult = api.Post(url, student);
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
            List<Student> list = new List<Student>();
            string url = apiurl + "Student/GetAll";
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
        public JsonResult Edit(int Id)
        {
            Student obj = new Student();
            string url = apiurl + "Student/GetStudentById?id=" + Id + "";
            try
            {
                Response responseResult = api.Get(url);
                if (responseResult.status)
                {
                    obj = JsonConvert.DeserializeObject<Student>(responseResult.data.ToString());
                }

            }
            catch (Exception ex)
            {

            }
            return Json(obj, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Delete(int Id)
        {
            Student obj = new Student();
            Response responseResult = new Response();
            string url = apiurl + "Student/Delete?id=" + Id + "";
            try
            {
                responseResult = api.Get(url);


            }
            catch (Exception ex)
            {
                throw;
            }

            return Json(obj, JsonRequestBehavior.AllowGet);
        }


        public JsonResult SendForApprove(int Id)
        {
            Student obj = new Student();
            Response responseResult = new Response();
            string url = apiurl + "Student/SendWaitingForApprovel?id=" + Id + "";
            try
            {
                responseResult = api.Get(url);


            }
            catch (Exception ex)
            {
                throw;
            }

            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Student_Mark()
        {
            return View();
        }
        //public JsonResult Student_Marks(string Id,string Name,string Year)
        //{

        //    Student obj = new Student();
        //    string url = "https://localhost:44331/api/Student/MarkGetStudentById?Id=22&Name=&Year=";
        //    try
        //    {
        //        Response responseResult = api.Get(url);
        //        if (responseResult.status)
        //        {
        //            obj = JsonConvert.DeserializeObject<Student>(responseResult.data.ToString());
        //        }

        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return Json(obj, JsonRequestBehavior.AllowGet);
        //}

        public JsonResult Student_MarkDetail(int Id)
        {
            Student obj = new Student();
            string url = apiurl + "Student/GetStudentDetailById?id=" + Id + "";
            try
            {
                Response responseResult = api.Get(url);
                if (responseResult.status)
                {
                    obj = JsonConvert.DeserializeObject<Student>(responseResult.data.ToString());
                }

            }
            catch (Exception ex)
            {

            }
            return Json(obj, JsonRequestBehavior.AllowGet);

        }
        public JsonResult Student_MarkDetailNameYear(string Name, string Year)
        {
            Student obj = new Student();
            string url = apiurl + "Student/GetStudentDetailByNameYear?Name=" + Name + "&Year=" + Year + "";
            try
            {
                Response responseResult = api.Get(url);
                if (responseResult.status)
                {
                    obj = JsonConvert.DeserializeObject<Student>(responseResult.data.ToString());
                }

            }
            catch (Exception ex)
            {

            }
            return Json(obj, JsonRequestBehavior.AllowGet);

        }

        public ActionResult Institute_Profile()
        {
            return View();
        }

        //public ActionResult InstituteUpadateStudent_Status(Student Student);
        //{ 
        // Response responseToView = new Response();
        //retu
        public JsonResult SetStatus(int Id ,string Status)
        {
            Student obj = new Student();
            string url = apiurl + "Student/UpdateStudentStatus?id="+Id+"&Status="+Status+"";
            try
            {
                Response responseResult = api.Get(url);
                if (responseResult.status)
                {
                    obj = JsonConvert.DeserializeObject<Student>(responseResult.data.ToString());
                }

            }
            catch (Exception ex)
            {

            }
            return Json(obj, JsonRequestBehavior.AllowGet);

        }

    }
    }

        





    

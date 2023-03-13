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
using System.Net.Mail;

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
        public ActionResult Exam_Type()
        {
                    return View();
    }

        public JsonResult GetAllType()
        {
            List<Categorie> list = new List<Categorie>();
            string url = apiurl + "Categorie/GetAllType";
            try
            {
                Response responseResult = api.Get(url);
                if (responseResult.status)
                {
                    list = JsonConvert.DeserializeObject<List<Categorie>>(responseResult.data.ToString());
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetAll_Cat()
        {
            List<Categorie> list = new List<Categorie>();
            List<Categorie> list01 = new List<Categorie>();
            List<Categorie> list02 = new List<Categorie>();
            string url = apiurl + "Categorie/GetAll";
            try
            {
                Response responseResult = api.Get(url);
                if (responseResult.status)
                {
                    list = JsonConvert.DeserializeObject<List<Categorie>>(responseResult.data.ToString());
                    list01 = list.Where(x => x.p_id == 0).ToList();
                    List<int> ids = new List<int>();
                    ids = list.Where(x => x.p_id == 0).Select(a => a.id).ToList();
                    list02 = list.Where(x => x.p_id != 0 && ids.Contains(x.p_id)).ToList();
                    //ids= list.Where(x => x.p_id != 0 && ids.Contains(x.p_id)).Select(a => a.id).ToList();
                    // var subcat= list.Where(x => x.p_id != 0 && ids.Contains(x.p_id)).ToList();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return Json(list02, JsonRequestBehavior.AllowGet);
        }




        public JsonResult GetAllSubCategorie()
        {
            List<Categorie> list = new List<Categorie>();
            List<Categorie> list01 = new List<Categorie>();
            List<Categorie> list02 = new List<Categorie>();
            List<Categorie> list03 = new List<Categorie>();
            string url = apiurl + "Categorie/GetAll";
            try
            {
                Response responseResult = api.Get(url);
                if (responseResult.status)
                {
                    list = JsonConvert.DeserializeObject<List<Categorie>>(responseResult.data.ToString());
                    list01 = list.Where(x => x.p_id == 0).ToList();
                    List<int> ids = new List<int>();
                    List<int> ids2 = new List<int>();
                    ids = list.Where(x => x.p_id == 0).Select(a => a.id).ToList();
                    list02 = list.Where(x => x.p_id != 0 && ids.Contains(x.p_id)).ToList();
                    ids = list.Where(x => x.p_id != 0 && ids.Contains(x.p_id)).Select(a => a.id).ToList();
                    list03 = list.Where(x => x.p_id != 0 && ids.Contains(x.p_id)).ToList();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return Json(list03, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Exam_Title()
        {
            return View();
        }

        public JsonResult GetAll_Exam_title()
        {
            List<Exam> list = new List<Exam>();
            string url = apiurl + "Categorie/GetAllExam";
            try
            {
                Response responseResult = api.Get(url);
                if (responseResult.status)
                {
                    list = JsonConvert.DeserializeObject<List<Exam>>(responseResult.data.ToString());
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Exam_Question()
        {
            return View();
        }
        public JsonResult GetAll_Question()
        {
            List<Score> list = new List<Score>();
            string url = apiurl + "Categorie/GetAllScore"; 
            try
            {
                Response responseResult = api.Get(url);
                if (responseResult.status)
                {
                    list = JsonConvert.DeserializeObject<List<Score>>(responseResult.data.ToString());
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetAll_Question_Preview(int Id)
        {
            List<Score> list = new List<Score>();
            string url = apiurl + "Categorie/GetAllScore";
            try
            {
                Response responseResult = api.Get(url);
                if (responseResult.status)
                {
                    list = JsonConvert.DeserializeObject<List<Score>>(responseResult.data.ToString());
                    list = list.Where(x => x.Exam_id == Id).ToList();

                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        //[HttpGet]
        //public JsonResult ExamRequest(int id)
        //{
        //    Student obj = new Student();
        //    string url = apiurl + "Student/GetStudentById?id=" + id + "";
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
        public ActionResult ExamRequest()
        {
            return View();
        }
        public JsonResult GetAllExamReqStudent()
        {
            List<ExamLogin> list = new List<ExamLogin>();
            string url = apiurl + "Institute/GetAllExamRequest";
            try
            {
                Response responseResult = api.Get(url);
                if (responseResult.status)
                {
                    list = JsonConvert.DeserializeObject<List<ExamLogin>>(responseResult.data.ToString());
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return Json(list, JsonRequestBehavior.AllowGet);
        }


        public JsonResult ApproveForExam(int Student_Id)
        {
            ExamLogin obj = new ExamLogin();
            Response responseResult = new Response();
            Response responseResult3 = new Response();
            Student obc = new Student();
            Response responseResult2 = new Response();
            string url = apiurl + "Institute/ApproveExamRequest?id=" + Student_Id + "";
            string geturl = apiurl + "Student/GetStudentDetailBy_userid?userid=" + Student_Id + "";
            string geturl2 = apiurl + "Institute/ExamGetByStudentId?Student_Id=" + Student_Id + "";

            try
            {
                responseResult = api.Get(url);
                responseResult2 = api.Get(geturl);
                responseResult3 = api.Get(geturl2);

                Student obc2 =JsonConvert.DeserializeObject<Student>(responseResult2.data.ToString());
                ExamLogin obj2 = JsonConvert.DeserializeObject<ExamLogin>(responseResult3.data.ToString());


                obc.email = obc2.email;
                 obj.User_Id = obj2.User_Id;
                obj.Password = obj2.Password;
                string receivers = obc.email;
                string subject = "Your Exam Login Is Registerd";
                string ajentmassage = "Dear Student Your Id " + obj.User_Id + "Adn Password " + obj.Password + "";
                 SendEmail(receivers, subject, ajentmassage);

            }
            catch (Exception ex)
            {
                throw;
            }

            return Json(obj, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult SendEmail(string receiver, string subject, string message)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var senderEmail = new MailAddress("jayhind3570@gmail.com", "Jamil");
                    var receiverEmail = new MailAddress(receiver, "Receiver");
                    var password = "fgfouhtbnlquukim";
                    var sub = subject;
                    var body = message;
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderEmail.Address, password)
                    };
                    using (var mess = new MailMessage(senderEmail, receiverEmail)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        smtp.Send(mess);
                    }
                    return View();
                }
            }
            catch (Exception ex)                             
            {
                ViewBag.Error = "Some Error";
            }
            return View();
        }

        
    }

}

        





    

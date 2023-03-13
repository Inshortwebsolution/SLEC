using Newtonsoft.Json;
using SharedModel.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SLEC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        string apiurl = ConfigurationManager.AppSettings["SLEC_APIurl"].ToString();

        ICommonAPI api = new CommonAPI();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login login)
        {
            Response responseToView = new Response();
            try
            {
                string url = apiurl + "/Login/Emaillogin";
                Response responseResult = api.Post(url, login);
                Login lgn = JsonConvert.DeserializeObject<Login>(responseResult.data.ToString());
                if (responseResult.status)
                {
                    if (responseResult.status)
                    {
                        if (lgn.type == "Student")
                        {
                            string getuserId = apiurl + "Student/GetStudentDetailBy_Email?email=" + login.username + "";
                             responseResult = api.Get(getuserId);
                            Student userid = JsonConvert.DeserializeObject<Student>(responseResult.data.ToString());
                            Session["Student_Detail"] = userid.userid;
                            Session["Student_Name"] = userid.name;
                            Session["Student_Id"] = userid.id;
                            Session["Student_Father"] = userid.f_name;
                            Session["Student_Mobile"] = userid.whats_no_self;
                            Session["Student_DOB"] = userid.dob;
                            Session["Student_Email"] = userid.email;
                            Response.Redirect("/Student_/Profile");
                        }
                        else if (lgn.type == "Institute")
                        {
                            Session["UserDetails"] = lgn;
                            Response.Redirect("/Institute/Index");

                        }
                        else if (lgn.type == "Admin")
                        {
                            Session["UserDetails"] = lgn;
                            Response.Redirect("/Admin/Index");
                        }
                    }
                }
                else { responseToView.status = false; responseToView.error = responseResult.error; }
            }
            catch (Exception ex)
            {
                responseToView.status = false;
                responseToView.error = "Server Error";
            }
            return View();
        }


        [HttpPost]
        public JsonResult Exam_Login(ExamLogin examLogin)
        {
            bool status = false;
            Response responseToView = new Response();
            try
            {
                string url = apiurl + "/Login/ExamLogin";
                Response responseResult = api.Post(url, examLogin);
                ExamLogin lgn = JsonConvert.DeserializeObject<ExamLogin>(responseResult.data.ToString());
                if (responseResult.status)
                {
                    if (responseResult.status)
                    {
                          
                        ExamLogin User_Id = JsonConvert.DeserializeObject<ExamLogin>(responseResult.data.ToString());
                        Session["Exam_Detail"] =User_Id.User_Id;
                        status = true;

                        //return RedirectToAction("Exam_Manage", "Exam_Profile");
                        //Response.Redirect("/Exam_Manage/Exam_Profile");
                    }
                }
                else { responseToView.status = false; responseToView.error = responseResult.error; }
            }
            catch (Exception ex)
            {
                responseToView.status = false;
                responseToView.error = "Server Error";
            }
            return Json(status,JsonRequestBehavior.AllowGet);
        }
    }


}


    


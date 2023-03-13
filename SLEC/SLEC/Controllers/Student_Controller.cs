using Newtonsoft.Json;
using SharedModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SLEC_API.Models;
using System.Configuration;

namespace SLEC.Controllers
{
    public class Student_Controller : Controller
    {

        string apiurl = ConfigurationManager.AppSettings["SLEC_APIurl"].ToString();
        IWSSLSEEntities db = new IWSSLSEEntities();
        ICommonAPI api = new CommonAPI();
        // GET: Student_
        public ActionResult Index()
        {
            return View();
        }

       

        public ActionResult Profile()
        {
           

            return View();
        }
        public JsonResult getby_Email(string email)
        {
            Student obj = new Student();
            string url = apiurl + "Student/GetStudentDetailBy_Email?email=" + email + "";
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

        public JsonResult GetBy_Userid()
        {
           int userid = Convert.ToInt32(Session["Student_Detail"]);
            Student obj = new Student();
            string url = apiurl + "Student/GetStudentDetailBy_userid?userid=" + userid + "";
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
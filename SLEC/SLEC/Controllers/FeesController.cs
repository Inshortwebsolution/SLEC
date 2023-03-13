using Newtonsoft.Json;
using SharedModel.Models;
using SLEC_API.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SLEC.Controllers
{
    public class FeesController : Controller
    {
        string apiurl = ConfigurationManager.AppSettings["SLEC_APIurl"].ToString();
        IWSSLSEEntities db = new IWSSLSEEntities();
        ICommonAPI api = new CommonAPI();
        // GET: Fees
        public ActionResult Index()
        {
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


       public JsonResult Student_MarkDetail(int Id)
        {
            Student obj = new Student();
            List<Student> list = new List<Student>();
            string url = apiurl + "Student/GetAll";
            try
            {
                Response responseResult = api.Get(url);
                if (responseResult.status)
                {
                    list = JsonConvert.DeserializeObject<List<Student>>(responseResult.data.ToString());
                    list.Where(x => x.id == Id).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {                
                throw;
            }
            return Json(list, JsonRequestBehavior.AllowGet);

        }
        public ActionResult Collect_Fees()
        {
            return View();
        }

        public ActionResult  View_Fees_History(string STID)
        {
            IWS_Student obj = new IWS_Student();
            obj.id = Convert.ToInt32(STID);
            return View(obj);
        }

        public JsonResult GetByStudent_ID(int Id)
        {
            Student obj = new Student();
            IWS_Courses ob = new IWS_Courses();
            string url = apiurl + "Student/GetStudentById?id=" + Id + "";
            
            Response responseResult = api.Get(url);
                if (responseResult.status)
                {
                    obj = JsonConvert.DeserializeObject<Student>(responseResult.data.ToString());
                }

                string url2 = apiurl + "Course/GetCourcesById?id=" + obj.course_name + "";
                Response responseResult2 = api.Get(url2);
                if (responseResult2.status)
                {
                    ob = JsonConvert.DeserializeObject<IWS_Courses>(responseResult2.data.ToString());
                }
            Tuple<Student, IWS_Courses> obj3 = new Tuple<Student, IWS_Courses>(obj, ob);

            return Json(obj3, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Student_Detail(int Id)
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
        public ActionResult Payment()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Save_Payment(Payment payment)
        {
            Response responseToView = new Response();
            string url = apiurl + "Payment/SavePayment";
            try
            {
                Response responseResult = api.Post(url, payment);
                if (responseResult.status)
                {
                    responseToView.status = true;
                    responseToView.data = responseResult.data;

                }
                else { responseToView.status = false; responseToView.error = responseResult.error; }
            }
            catch (Exception ex)
            {

                throw;
            }
            return Json(responseToView, JsonRequestBehavior.AllowGet); ;
        }
        public JsonResult GetAllPayment()
        {
            List<Payment> list = new List<Payment>();
            string url = apiurl + "Payment/GetAll";
            try
            {
                Response responseResult = api.Get(url);
                if (responseResult.status)
                {
                    list = JsonConvert.DeserializeObject<List<Payment>>(responseResult.data.ToString());
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Delete(int Id)
        {
           Payment obj = new Payment();
            Response responseResult = new Response();
            string url = apiurl + "Payment/Delete?id=" + Id + "";
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

    }
}
using Newtonsoft.Json;
using SharedModel.Models;
using SLEC_API.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SLEC.Controllers
{
    public class Exam_ManageController : Controller
    {
        // GET: Exam_Manage

        string apiurl = ConfigurationManager.AppSettings["SLEC_APIurl"].ToString();
        IWSSLSEEntities db = new IWSSLSEEntities();
        ICommonAPI api = new CommonAPI();
        public ActionResult Exam_Profile()
        {
            return View();
        }
        public ActionResult MoC()
        {
            return View();
        }
        public JsonResult Student_ExamReq()
        {
           
            
            Student obj = new Student();
            obj.userid = Convert.ToInt32(Session["Student_Detail"].ToString());
            string url = apiurl + "Student/RequestFor_Exam?id=" + obj.userid + "";
            try
            {
                Response responseResult = api.Post(url,obj);
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
        public ActionResult StudentExam_Profile()
        {
            return View();
        }
        public JsonResult GetAll_Exam_title()
        {
            List<Exam> list = new List<Exam>();
            string url = apiurl + "ExamManage/GetAllExamTitle";
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
        

        public JsonResult CategorieGetById(int Id)
        {
            Categorie obj = new Categorie();
            string url = apiurl + "Categorie/GetAll";
            List<Categorie> list = new List<Categorie>();
            try
            {
                Response responseResult = api.Get(url);
                if (responseResult.status)
                {
                    list = JsonConvert.DeserializeObject<List<Categorie>>(responseResult.data.ToString());
                    list = list.Where(x => x.p_id == Id).ToList();
                }

            }
            catch (Exception ex)
            {

            }
            return Json(list, JsonRequestBehavior.AllowGet);
        }


        public JsonResult SubCategorieGetCatById(int Id)
        {
            Categorie obj = new Categorie();
            string url = apiurl + "Categorie/GetAll";
            List<Categorie> list = new List<Categorie>();
            try
            {
                Response responseResult = api.Get(url);
                if (responseResult.status)
                {
                    list = JsonConvert.DeserializeObject<List<Categorie>>(responseResult.data.ToString());
                    list = list.Where(x => x.p_id == Id).ToList();

                }

            }
            catch (Exception ex)
            {

            }
            return Json(list, JsonRequestBehavior.AllowGet);
        }

    }
}
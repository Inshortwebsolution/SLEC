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
    public class ExamController : Controller
    {
        string apiurl = ConfigurationManager.AppSettings["SLEC_APIurl"].ToString();
        IWSSLSEEntities db = new IWSSLSEEntities();
        ICommonAPI api = new CommonAPI();
        // GET: Exam
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Exams()
        {
            return View();
        }
        public ActionResult Categorie()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Save_Type(Categorie categorie)
        {
            Response responseToView = new Response();

            try
            {
                if (categorie != null)
                {
                    string url = apiurl + "Categorie/SaveType";
                    string updateurl = apiurl + "Categorie/UpdateType";
                    if (categorie.id > 0)
                    {

                        categorie.update_by = 2;
                        categorie.update_date = DateTime.Now;
                        categorie.isactive = true;
                        categorie.isdeleted = false;

                        Response responseResult = api.Post(updateurl, categorie);
                        if (responseResult.status)
                        {
                            responseToView.status = true;
                            responseToView.data = responseResult.data;

                        }
                        else { responseToView.status = false; responseToView.error = responseResult.error; }
                    }
                    else
                    {
                        categorie.update_by = 0;
                        categorie.update_date = DateTime.Now;
                        categorie.isactive = true;
                        categorie.isdeleted = false;
                        Response responseResult = api.Post(url, categorie);
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
            return Json(responseToView, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult Save_Categorie(Categorie categorie)
        {
            Response responseToView = new Response();
            try
            {
                if (categorie != null)
                {
                    string url = apiurl + "Categorie/SaveCategorie";
                    string updateurl = apiurl + "Categorie/UpdateCategory";

                    if (categorie.id > 0)
                    {
                        categorie.update_by = 2;
                        categorie.update_date = DateTime.Now;
                        categorie.isactive = true;
                        categorie.isdeleted = false;

                        Response responseResult = api.Post(updateurl, categorie);
                        if (responseResult.status)
                        {
                            responseToView.status = true;
                            responseToView.data = responseResult.data;

                        }
                        else { responseToView.status = false; responseToView.error = responseResult.error; }
                    }
                    else
                    {
                        categorie.update_by = 0;
                        categorie.update_date = DateTime.Now;
                        categorie.isactive = true;
                        categorie.isdeleted = false;
                        Response responseResult = api.Post(url, categorie);
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
            return Json(responseToView, JsonRequestBehavior.AllowGet); ;
        }

        [HttpGet]
        public JsonResult GetAll()
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



        public ActionResult Sub_Categorie()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Save_SubCategorie(Categorie categorie)
        {
            Response responseToView = new Response();
           
            try
            {
                if (categorie != null)
                {
                    string url = apiurl + "Categorie/Save_SubCategorie";
                    string updateurl = apiurl + "Categorie/UpdateSubCategory";

                    if (categorie.id > 0)
                    {
                        categorie.update_by = 2;
                        categorie.update_date = DateTime.Now;
                        categorie.isactive = true;
                        categorie.isdeleted = false;

                        Response responseResult = api.Post(updateurl, categorie);
                        if (responseResult.status)
                        {
                            responseToView.status = true;
                            responseToView.data = responseResult.data;

                        }
                        else { responseToView.status = false; responseToView.error = responseResult.error; }
                    }
                    else
                    {
                        categorie.update_by = 0;
                        categorie.update_date = DateTime.Now;
                        categorie.isactive = true;
                        categorie.isdeleted = false;
                        Response responseResult = api.Post(url, categorie);
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
            return Json(responseToView, JsonRequestBehavior.AllowGet); ;
        }
        public ActionResult Exam_Type()
        {
            return View();
        }

        [HttpGet]
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

        public JsonResult TypeEdit(int Id)
        {
            Categorie obj = new Categorie();
            string url = apiurl + "Categorie/GetTypeById?id=" + Id + "";
            try
            {
                Response responseResult = api.Get(url);
                if (responseResult.status)
                {
                    obj = JsonConvert.DeserializeObject<Categorie>(responseResult.data.ToString());
                }

            }
            catch (Exception ex)
            {

            }
            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        public JsonResult TypeDelete(int Id)
        {
            Response responseResult = new Response();
            Categorie obj = new Categorie();
            string url = apiurl + "Categorie/TypeDelete?id=" + Id + "";
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



        [HttpGet]
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


        public JsonResult BindSubCategorieGetById(int Id)
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



        public ActionResult Exam_Title()
        {
            return View();
        }



        public JsonResult BindSubCategorieGetCatById(int Id)
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


        public JsonResult Save_Exam_Title(Exam exam)
        {
            Response responseToView = new Response();
           
            try
            {
                if (exam != null)
                {
                    string url = apiurl + "Categorie/SaveExam_Title";
                    string updateurl = apiurl + "Categorie/UpdateExam_Title";
                    if (exam.Exam_Id > 0)
                    {

                        exam.Updated_By = 2;
                       exam.Updated_Date = DateTime.Now;
                        exam.Isactive = true;
                        exam.Isdeleted = false;

                        Response responseResult = api.Post(updateurl, exam);
                        if (responseResult.status)
                        {
                            responseToView.status = true;
                            responseToView.data = responseResult.data;

                        }
                        else { responseToView.status = false; responseToView.error = responseResult.error; }
                    }
                    else
                    {
                        exam.Updated_By = 2;
                        exam.Updated_Date = DateTime.Now;
                        exam.Isactive = true;
                        exam.Isdeleted = false;
                        Response responseResult = api.Post(url, exam);
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
            return Json(responseToView, JsonRequestBehavior.AllowGet); ;
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



        public JsonResult EditExam_Title(int Id)
        {
            Exam obj = new Exam();
            string url = apiurl + "Categorie/GetById_Exam_Title?id=" + Id + "";
            try
            {
                Response responseResult = api.Get(url);
                if (responseResult.status)
                {
                    obj = JsonConvert.DeserializeObject<Exam>(responseResult.data.ToString());
                }

            }
            catch (Exception ex)
            {

            }
            return Json(obj, JsonRequestBehavior.AllowGet);
        }
        public JsonResult DeleteExam_Title(int Id)
        {
            Exam obj = new Exam();
            Response responseResult = new Response();
            string url = apiurl + "Categorie/DeleteExam_Title?id=" + Id + "";
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



        public ActionResult Exam_Question()
        {
            return View();
        }

        public JsonResult SaveExam_Question(Score score)
        {
            Response responseToView = new Response();
           
            try
            {
                if (score != null)
                {
                    string url = apiurl + "Categorie/SaveExamScore";
                    string updateurl = apiurl + "Categorie/UpdateExam_Score";
                    if (score.Question_NO> 0)
                    {

                        score.Updated_By = 2;
                        score.Updated_Date = DateTime.Now;
                        score.IsActive = true;
                        score.IsDeleted = false;

                        Response responseResult = api.Post(updateurl, score);
                        if (responseResult.status)
                        {
                            responseToView.status = true;
                            responseToView.data = responseResult.data;

                        }
                        else { responseToView.status = false; responseToView.error = responseResult.error; }
                    }
                    else
                    {
                        score.Updated_By = 2;
                        score.Updated_Date = DateTime.Now;
                        score.IsActive = true;
                        score.IsDeleted = false;
                        Response responseResult = api.Post(url, score);
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
            return Json(responseToView, JsonRequestBehavior.AllowGet); ;
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

        public JsonResult Edit_ExamQuestion(int Id)
        {
            Score obj = new Score();
            string url = apiurl + "Categorie/GetById_Score?id=" + Id + "";
            try
            {
                Response responseResult = api.Get(url);
                if (responseResult.status)
                {
                    obj = JsonConvert.DeserializeObject<Score>(responseResult.data.ToString());
                }

            }
            catch (Exception ex)
            {

                throw;
            }
            return Json(obj, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Delete_ExamQuestion(int Id)
        {
            Response responseResult = new Response();
            Score obj = new Score();
            string url = apiurl + "Categorie/Score_Delete?id=" + Id + "";
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
        public JsonResult EditCat(int Id)
        {
            Categorie obj = new Categorie();
            string url = apiurl + "Categorie/GetCatById?id=" + Id + "";
            try
            {
                Response responseResult = api.Get(url);
                if (responseResult.status)
                {
                    obj = JsonConvert.DeserializeObject<Categorie>(responseResult.data.ToString());
                }

            }
            catch (Exception ex)
            {

            }
            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        public JsonResult EditSubCat(int Id)
        {
            Categorie obj = new Categorie();
            string url = apiurl + "Categorie/GetSubCatById?id=" + Id + "";
            try
            {
                Response responseResult = api.Get(url);
                if (responseResult.status)
                {
                    obj = JsonConvert.DeserializeObject<Categorie>(responseResult.data.ToString());
                }

            }
            catch (Exception ex)
            {

            }
            return Json(obj, JsonRequestBehavior.AllowGet);
        }
    }
}
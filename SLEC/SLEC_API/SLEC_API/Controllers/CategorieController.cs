using Newtonsoft.Json;
using SharedModel.Models;
using SLEC_API.Helper;
using SLEC_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SLEC_API.Controllers
{
    public class CategorieController : ApiController
    {
        ICategorieRepo Ico = new CategorieRepo();

        public object Repo { get; private set; }

        [Route("api/Categorie/SaveType")]
        [HttpPost]
        public HttpResponseMessage SaveType(IWS_Categories categorie)
        {
            Response response = new Response();
            try
            {

                bool n = Ico.SaveType(categorie);
                if (n)
                {
                    response.status = true;
                    response.data = n;
                }
                else
                {
                    response.status = false;
                }
            }
            catch (Exception ex)
            {
                response.status = false;
                response.error = ex.Message.ToString();
                return Request.CreateResponse(HttpStatusCode.BadRequest, response);
            }

            return Request.CreateResponse(HttpStatusCode.Created, response);
        }

        [Route("api/Categorie/GetAllType")]
        [HttpGet]
        public HttpResponseMessage GetAllType()
        {
            Response response = new Response();
            List<Categorie> lst = new List<Categorie>();
            try
            {
                lst = Ico.GetAllType();
                if (lst.Count > 0)
                {
                    response.status = true;
                    response.data = lst;
                }
                else
                {
                    response.status = false;
                }
            }
            catch (Exception ex)
            {
                response.status = false;
                response.error = ex.Message.ToString();
            }

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        [Route("api/Categorie/UpdateType")]
        [HttpPost]
        public HttpResponseMessage UpdateType(Categorie categorie)
        {
            Response response = new Response();
            try
            {

                bool n = Ico.UpdateType(categorie);
                if (n)
                {
                    response.status = true;
                    response.data = n;
                }
                else
                {
                    response.status = false;
                }
            }
            catch (Exception ex)
            {
                response.status = false;
                response.error = ex.Message.ToString();
            }

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        [Route("api/Categorie/GetTypeById")]
        [HttpGet]
        public HttpResponseMessage GetTypeById(int id)
        {
            Response response = new Response();
            Categorie categorie = new Categorie();
            try
            {

                categorie = Ico.GetByIdtype(id);
                if (categorie != null)
                {
                    response.status = true;
                    response.data = categorie;
                }
                else
                {
                    response.status = false;
                }
            }
            catch (Exception ex)
            {
                response.status = false;
                response.error = ex.Message.ToString();
            }

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }





        [Route("api/Categorie/TypeDelete")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            Response response = new Response();
            bool Categorie = false;
            try
            {

                Categorie = Ico.DeleteType(id);
                if (Categorie)
                {
                    response.status = true;
                    response.data = Categorie;
                }
                else
                {
                    response.status = false;
                }
            }
            catch (Exception ex)
            {
                response.status = false;
                response.error = ex.Message.ToString();
            }

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }


        [Route("api/Categorie/SaveCategorie")]
        [HttpPost]
        public HttpResponseMessage SaveCategorie(IWS_Categories categorie)
        {
            Response response = new Response();
            try
            {

                bool n = Ico.SaveCategorie(categorie);
                if (n)
                {
                    response.status = true;
                    response.data = n;
                }
                else
                {
                    response.status = false;
                }
            }
            catch (Exception ex)
            {
                response.status = false;
                response.error = ex.Message.ToString();
                return Request.CreateResponse(HttpStatusCode.BadRequest, response);
            }

            return Request.CreateResponse(HttpStatusCode.Created, response);
        }


        [Route("api/Categorie/UpdateCategory")]
        [HttpPost]
        public HttpResponseMessage UpdateCategory(Categorie categorie)
        {
            Response response = new Response();
            try
            {

                bool n = Ico.UpdateCat(categorie);
                if (n)
                {
                    response.status = true;
                    response.data = n;
                }
                else
                {
                    response.status = false;
                }
            }
            catch (Exception ex)
            {
                response.status = false;
                response.error = ex.Message.ToString();
            }

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }
        [Route("api/Categorie/GetCatById")]
        [HttpGet]
        public HttpResponseMessage GetCatById(int id)
        {
            Response response = new Response();
            Categorie categorie = new Categorie();
            try
            {

                categorie = Ico.GetCatById(id);
                if (categorie != null)
                {
                    response.status = true;
                    response.data = categorie;
                }
                else
                {
                    response.status = false;
                }
            }
            catch (Exception ex)
            {
                response.status = false;
                response.error = ex.Message.ToString();
            }

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }


        [Route("api/Categorie/GetAll")]
        [HttpGet]
        public HttpResponseMessage All()
        {
            Response response = new Response();
            List<Categorie> lst = new List<Categorie>();
            try
            {
                lst = Ico.GetAll();
                if (lst.Count > 0)
                {
                    response.status = true;
                    response.data = lst;
                }
                else
                {
                    response.status = false;
                }
            }
            catch (Exception ex)
            {
                response.status = false;
                response.error = ex.Message.ToString();
            }

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }



        [Route("api/Categorie/Save_SubCategorie")]
        [HttpPost]
        public HttpResponseMessage Save_SubCategorie(IWS_Categories categorie)
        {
            Response response = new Response();
            try
            {

                bool n = Ico.Save_SubCategorie(categorie);
                if (n)
                {
                    response.status = true;
                    response.data = n;
                }
                else
                {
                    response.status = false;
                }
            }
            catch (Exception ex)
            {
                response.status = false;
                response.error = ex.Message.ToString();
                return Request.CreateResponse(HttpStatusCode.BadRequest, response);
            }

            return Request.CreateResponse(HttpStatusCode.Created, response);
        }
        [Route("api/Categorie/UpdateSubCategory")]
        [HttpPost]
        public HttpResponseMessage UpdateSUbCategory(Categorie categorie)
        {
            Response response = new Response();
            try
            {

                bool n = Ico.UpdateSubCat(categorie);
                if (n)
                {
                    response.status = true;
                    response.data = n;
                }
                else
                {
                    response.status = false;
                }
            }
            catch (Exception ex)
            {
                response.status = false;
                response.error = ex.Message.ToString();
            }

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        [Route("api/Categorie/GetSubCatById")]
        [HttpGet]
        public HttpResponseMessage GetSubCatById(int id)
        {
            Response response = new Response();
            Categorie categorie = new Categorie();
            try
            {

                categorie = Ico.GetSubCatById(id);
                if (categorie != null)
                {
                    response.status = true;
                    response.data = categorie;
                }
                else
                {
                    response.status = false;
                }
            }
            catch (Exception ex)
            {
                response.status = false;
                response.error = ex.Message.ToString();
            }

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }


        [Route("api/Categorie/SaveExam_Title")]
        [HttpPost]
        public HttpResponseMessage SaveExam_Title(IWS_Exam exam)
        {
            Response response = new Response();
            try
            {

                bool n = Ico.SaveExamTitle(exam);
                if (n)
                {
                    response.status = true;
                    response.data = n;
                }
                else
                {
                    response.status = false;
                }
            }
            catch (Exception ex)
            {
                response.status = false;
                response.error = ex.Message.ToString();
                return Request.CreateResponse(HttpStatusCode.BadRequest, response);
            }

            return Request.CreateResponse(HttpStatusCode.Created, response);
        }

        [Route("api/Categorie/GetAllExam")]
        [HttpGet]
        public HttpResponseMessage GetAllExam()
        {
            Response response = new Response();
            List<Exam> lst = new List<Exam>();
            try
            {
                lst = Ico.GetAllExam();
                if (lst.Count > 0)
                {
                    response.status = true;
                    response.data = lst;
                }
                else
                {
                    response.status = false;
                }
            }
            catch (Exception ex)
            {
                response.status = false;
                response.error = ex.Message.ToString();
            }

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }



        [Route("api/Categorie/UpdateExam_Title")]
        [HttpPost]
        public HttpResponseMessage UpdateExam_Title(Exam exam)
        {
            Response response = new Response();
            try
            {

                bool n = Ico.UpdateExam(exam);
                if (n)
                {
                    response.status = true;
                    response.data = n;
                }
                else
                {
                    response.status = false;
                }
            }
            catch (Exception ex)
            {
                response.status = false;
                response.error = ex.Message.ToString();
            }

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        [Route("api/Categorie/GetById_Exam_Title")]
        [HttpGet]
        public HttpResponseMessage GetById_Exam_Title(int id)
        {
            Response response = new Response();
            Exam exam = new Exam();
            try
            {

                exam = Ico.GetByIdExam(id);
                if (exam != null)
                {
                    response.status = true;
                    response.data = exam;
                }
                else
                {
                    response.status = false;
                }
            }
            catch (Exception ex)
            {
                response.status = false;
                response.error = ex.Message.ToString();
            }

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }






        [Route("api/Categorie/DeleteExam_Title")]
        [HttpGet]
        public HttpResponseMessage DeleteExam_Title(int id)
        {
            Response response = new Response();
            bool exam = false;
            try
            {

                exam = Ico.DeleteExam_Title(id);
                if (exam)
                {
                    response.status = true;
                    response.data = exam;
                }
                else
                {
                    response.status = false;
                }
            }
            catch (Exception ex)
            {
                response.status = false;
                response.error = ex.Message.ToString();
            }

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }





        [Route("api/Categorie/SaveExamScore")]
        [HttpPost]
        public HttpResponseMessage SaveExamScore(Score score)
        {
            Response response = new Response();
            try
            {

                bool n = Ico.Save(score);
                if (n)
                {
                    response.status = true;
                    response.data = n;
                }
                else
                {
                    response.status = false;
                }
            }
            catch (Exception ex)
            {
                response.status = false;
                response.error = ex.Message.ToString();
                return Request.CreateResponse(HttpStatusCode.BadRequest, response);
            }

            return Request.CreateResponse(HttpStatusCode.Created, response);
        }


        [Route("api/Categorie/UpdateExam_Score")]
        [HttpPost]
        public HttpResponseMessage UpdateExam_Score(Score score)
        {
            Response response = new Response();
            try
            {

                bool n = Ico.Update(score);
                if (n)
                {
                    response.status = true;
                    response.data = n;
                }
                else
                {
                    response.status = false;
                }
            }
            catch (Exception ex)
            {
                response.status = false;
                response.error = ex.Message.ToString();
            }

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        [Route("api/Categorie/GetAllScore")]
        [HttpGet]
        public HttpResponseMessage GetAllScore()
        {
            Response response = new Response();
            List<Score> lst = new List<Score>();
            try
            {
                lst = Ico.GetAllScore();
                if (lst.Count > 0)
                {
                    response.status = true;
                    response.data = lst;
                }
                else
                {
                    response.status = false;
                }
            }
            catch (Exception ex)
            {
                response.status = false;
                response.error = ex.Message.ToString();
            }

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }
        [Route("api/Categorie/GetById_Score")]
        [HttpGet]
        public HttpResponseMessage GetById_Score(int id)
        {
            Response response = new Response();
            Score score = new Score();
            try
            {

                score = Ico.GetById(id);
                if (score != null)
                {
                    response.status = true;
                    response.data = score;
                }
                else
                {
                    response.status = false;
                }
            }
            catch (Exception ex)
            {
                response.status = false;
                response.error = ex.Message.ToString();
            }

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }
        [Route("api/Categorie/Score_Delete")]
        [HttpGet]
        public HttpResponseMessage Score_Delete(int id)
        {
            Response response = new Response();
            bool score = false;
            try
            {

                score = Ico.DeleteScore(id);
                if (score)
                {
                    response.status = true;
                    response.data = score;
                }
                else
                {
                    response.status = false;
                }
            }
            catch (Exception ex)
            {
                response.status = false;
                response.error = ex.Message.ToString();
            }

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }


    }
}

using SharedModel.Models;
using SLEC_API.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SLEC_API.Controllers
{
   
        public class InstituteController : ApiController
        {
            IInstituteRepo Repo = new InstituteRepo();
            // GET: Products

            [Route("api/Institute/Save")]
            [HttpPost]
            public HttpResponseMessage SaveInstitute(Institute inst)
            {
                Response response = new Response();
                try
                {

                    bool n = Repo.Save(inst);
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

            //getall
            //getbyid
            //update
            //delete
            //getApprovedinstitute
            //getunAapproved
            [Route("api/Institute/GetAll")]
            [HttpGet]
            public HttpResponseMessage All()
            {
                Response response = new Response();
                List<Institute> lst = new List<Institute>();
                try
                {
                  lst = Repo.GetAll();
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

            [Route("api/Institute/GetById")]
            [HttpGet]
            public HttpResponseMessage GetById(int id)
            {
                Response response = new Response();
                Institute inst = new Institute();
                try
                {

                    inst = Repo.GetById(id);
                    if (inst != null)
                    {
                        response.status = true;
                        response.data = inst;
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

            [Route("api/Institute/Update")]
            [HttpPost]
            public HttpResponseMessage UpdateInstitute(Institute inst)
            {
                Response response = new Response();
                try
                {

                    bool n = Repo.Update(inst);
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

            [Route("api/Institute/Delete")]
            [HttpGet]
            public HttpResponseMessage Delete(int id)
            {
                Response response = new Response();
                bool inst = false;
                try
                {
                    inst = Repo.Delete(id);
                    if (inst)
                    {
                        response.status = true;
                        response.data = inst;
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
        [Route("api/Institute/GetAllExamRequest")]
        [HttpGet]
        public HttpResponseMessage GetAllExamRequest()
        {
            Response response = new Response();
            List<ExamLogin> lst = new List<ExamLogin>();
            try
            {
                lst = Repo.GetAllExamReq();
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
        [Route("api/Institute/ApproveExamRequest")]
        [HttpGet]
        public HttpResponseMessage ApproveExamRequest(int? id)
        {
            Response response = new Response();
            try
            {

                bool n = Repo.ApproveReq(id);
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

        [Route("api/Institute/ExamGetByStudentId")]
        [HttpGet]
        public HttpResponseMessage ExamGetByStudentId(int Student_Id)
        {
            Response response = new Response();
            ExamLogin inst = new ExamLogin();
            try
            {

                inst = Repo.GetByStudentId(Student_Id);
                if (inst != null)
                {
                    response.status = true;
                    response.data = inst;
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
    


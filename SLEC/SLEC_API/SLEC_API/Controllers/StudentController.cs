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
    public class StudentController : ApiController
    {
        IStudentRepo Sto = new StudentRepo();
        
        [Route("api/Student/GetAll")]
        [HttpGet]
        public HttpResponseMessage All()
        {
            Response response = new Response();
            List<Student> lst = new List<Student>();
            try
            {
                lst = Sto.GetAll();
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
        [Route("api/Student/SaveStudent")]
        [HttpPost]
        public HttpResponseMessage SaveStudent(IWS_Student student)
        {
            Response response = new Response();
            try
            {

                bool n = Sto.SaveStudent(student);
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
        [Route("api/Student/GetStudentById")]
        [HttpGet]
        public HttpResponseMessage GetStudentById(int id)
        {
            Response response = new Response();
            Student student = new Student();
            try
            {

                student = Sto.GetById(id);
                if (student != null)
                {
                    response.status = true;
                    response.data = student;
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
        [Route("api/Student/Update")]
        [HttpPost]
        public HttpResponseMessage UpdateStudent(Student student)
        {
            Response response = new Response();
            try
            {

                bool n = Sto.Update(student);
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
        [Route("api/Student/Delete")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            Response response = new Response();
            bool student = false;
            try
            {

                student = Sto.Delete(id);
                if (student)
                {
                    response.status = true;
                    response.data = student;
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

        [Route("api/Student/WaitingApprovel")]
        [HttpGet]
        public HttpResponseMessage WaitingApprovel()
        {
            Response response = new Response();
            List<Student> lst = new List<Student>();
            try
            {
                lst = Sto.GetAll();
                if (lst.Count > 0)
                {
                    response.status = true;
                    response.data = lst.Where(x => x.isOnline == true && x.isApprove == false && x.isdeleted == false);
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
        [Route("api/Student/GetAllApprovedStudent")]
        [HttpGet]
        public HttpResponseMessage GetAllApprovedStudent()
        {
            Response response = new Response();
            List<Student> lst = new List<Student>();
            try
            {
                lst = Sto.GetAll();
                if (lst.Count > 0)
                {
                    response.status = true;
                    response.data = lst.Where(x => x.isOnline == true && x.isApprove == true && x.isdeleted == false);
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


        [Route("api/Student/Approve")]
        [HttpGet]
        public HttpResponseMessage Approve(int? id)
        {
            Response response = new Response();
            try
            {

                bool n = Sto.Approve(id);
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

        [Route("api/Student/SendWaitingForApprovel")]
        [HttpGet]
        public HttpResponseMessage SendWaitingForApprovel(int? id)
        {
            Response response = new Response();
            try
            {

                bool n = Sto.SendForApprove(id);
                //set isonline 1
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

        [Route("api/Student/GetStudentDetailById")]
        [HttpGet]
        public HttpResponseMessage GetStudentDetailById(int id)
        {
            Response response = new Response();
            Student student = new Student();
            try
            {

                student = Sto.GetDetailById(id);
                if (student != null)
                {
                    response.status = true;
                    response.data = student;
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
        [Route("api/Student/GetStudentDetailByNameYear")]
        [HttpGet]
        public HttpResponseMessage GetStudentDetailByNameYear(string Name, string Year)
        {
            Response response = new Response();
            Student student = new Student();
            try
            {

                student = Sto.GetDetailByNameYear(Name, Year);
                if (student != null)
                {
                    response.status = true;
                    response.data = student;
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

        [Route("api/Student/UpdateStudentStatus")]
        [HttpGet]
        public HttpResponseMessage UpdateStatus(int id,string Status)
        {
            Response response = new Response();
            try
            {
                bool n = Sto.UpdateStatus(id,Status);
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

        [Route("api/Student/GetStudentDetailBy_Email")]
        [HttpGet]
        public HttpResponseMessage GetStudentDetailBy_Email(string email)
        {
            Response response = new Response();
            Student student = new Student();
            try
            {

                student = Sto.GetDetailByEmail(email);
                if (student != null)
                {
                    response.status = true;
                    response.data = student;
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

        [Route("api/Student/GetStudentDetailBy_userid")]
        [HttpGet]
        public HttpResponseMessage GetStudentDetailBy_userid(int userid)
        {
            Response response = new Response();
            Student student = new Student();
            try
            {

                student = Sto.GetDetailBy_userid(userid);
                if (student != null)
                {
                    response.status = true;
                    response.data = student;
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

        [Route("api/Student/RequestFor_Exam")]
        [HttpPost]
        public HttpResponseMessage RequestFor_Exam(int id)
        {
            Response response = new Response();
            try
            {
                bool n = Sto.RequestExam(id);
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

    }
}


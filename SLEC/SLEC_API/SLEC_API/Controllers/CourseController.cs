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
    public class CourseController : ApiController
    {
        ICourseRepo ico = new CourseRepo();
        [Route("api/Course/GetAll")]
        [HttpGet]
        public HttpResponseMessage All()
        {
            Response response = new Response();
            List<Course> lst = new List<Course>();
            try
            {
                lst = ico.GetAll();
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


        [Route("api/Course/SaveCourses")]
        [HttpPost]
        public HttpResponseMessage SaveCourses(Course course)
        {
            Response response = new Response();
            try
            {

                bool n = ico.SaveCourses(course);
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

        [Route("api/Course/GetCourcesById")]
        [HttpGet]
        public HttpResponseMessage GetCourcesById(int id)
        {
            Response response = new Response();
            Course course = new Course();
            try
            {

                course = ico.GetById(id);
                if (course != null)
                {
                    response.status = true;
                    response.data = course;
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

        [Route("api/Course/Update")]
        [HttpPost]
        public HttpResponseMessage UpdateCourse(Course course)
        {
            Response response = new Response();
            try
            {

                bool n = ico.Update(course);
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
        [Route("api/Course/Delete")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            Response response = new Response();
            bool course = false;
            try
            {

                course = ico.Delete(id);
                if (course)
                {
                    response.status = true;
                    response.data = course;
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

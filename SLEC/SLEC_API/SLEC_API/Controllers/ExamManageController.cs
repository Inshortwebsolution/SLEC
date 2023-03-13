using SLEC_API.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SLEC_API.Models;
using SharedModel.Models;

namespace SLEC_API.Controllers
{
    public class ExamManageController : ApiController
    {
        IExamManageRepo Exm = new ExamManageRepo();
        [Route("api/ExamManage/Save_ExamReq")]
        [HttpPost]
        public HttpResponseMessage Save_ExamReq(ExamLogin examLogin)
        {
            Response response = new Response();
            try
            {

                bool n = Exm.SaveExamLog(examLogin);
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
        [Route("api/ExamManage/GetAllExamTitle")]
        [HttpGet]
        
        public HttpResponseMessage GetAllExamTitle()
        {
            Response response = new Response();
            List<Exam> lst = new List<Exam>();
            try
            {
                lst = Exm.GetAllExmTitle();
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

        [Route("api/ExamManage/SaveExamHist")]
        [HttpPost]
        public HttpResponseMessage SaveExamHist(ExamHistory examHistory)
        {
            Response response = new Response();
            try
            {

                bool n = Exm.SaveExamHist(examHistory);
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

    }
}

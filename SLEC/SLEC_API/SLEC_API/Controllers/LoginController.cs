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
    public class LoginController : ApiController
    {
        // GET: api/Login
        ILoginRepo repo = new loginRepo();


        [Route("api/Login/Emaillogin")]
        [HttpPost]
        public HttpResponseMessage Emaillogin(Login login)
        {
            Response response = new Response();
            try
            {
                login = repo.Emaillogin(login);
                if (login != null)
                {
                    response.status = true;
                    response.data = login;
                }
                else
                {
                    response.status = false;
                    response.error = "Please Check Your username & Password";
                }
            }
            catch (Exception ex)
            {
                response.status = false;
                response.error = ex.Message.ToString();
                Request.CreateResponse(HttpStatusCode.BadRequest, response);
            }
            return Request.CreateResponse(HttpStatusCode.Created, response);
        }
       
    }
}

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
    public class AdminController : ApiController
    {
        IAdminRepo iad = new AdminRepo();
        // GET: api/Admin
    
        


       [HttpPost]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Admin
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Admin/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Admin/5
        public void Delete(int id)
        {
        }
    }
}

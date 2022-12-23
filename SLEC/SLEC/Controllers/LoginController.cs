using Newtonsoft.Json;
using SharedModel.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SLEC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        string apiurl = ConfigurationManager.AppSettings["SLEC_APIurl"].ToString();

        ICommonAPI api = new CommonAPI();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login login)
        {
            Response responseToView = new Response();
            try
            {
                string url = apiurl + "/Login/Emaillogin";
                Response responseResult = api.Post(url, login);
                Login lgn =JsonConvert.DeserializeObject<Login>(responseResult.data.ToString());
                if (responseResult.status)
                {
                    if (responseResult.status)
                    {
                        if (lgn.type == "Student")
                        {
                            Session["UserDetails"] = lgn;
                            Response.Redirect("/Admin/Student_Dashboard");
                        }
                        else if (lgn.type == "Institute")
                        {
                            Session["UserDetails"] = lgn;
                            Response.Redirect("/Institute/Index");

                        }
                        else if (lgn.type == "Admin")
                        {
                            Session["UserDetails"] = lgn;
                            Response.Redirect("/Admin/Index");
                        }
                    }
                }
                else { responseToView.status = false; responseToView.error = responseResult.error; }
            }
            catch (Exception ex)
            {
                responseToView.status = false;
                responseToView.error = "Server Error";
            }
            return View();
        }

    }

    
}

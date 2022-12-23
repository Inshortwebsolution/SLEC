using Newtonsoft.Json;
using SharedModel.Models;
using SLEC_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SLEC_API.Helper
{
    public class loginRepo : ILoginRepo
    {
        IWSSLSEEntities db = new IWSSLSEEntities();

        public Login Emaillogin(Login login)
        {
            List<Login> lst = new List<Login>();
            List<IWS_Login> iwslst = new List<IWS_Login>();
            iwslst = db.IWS_Login.Where(x => x.UserName ==login.username && x.password==login.password).ToList();
            string json = JsonConvert.SerializeObject(iwslst);
            lst = JsonConvert.DeserializeObject<List<Login>>(json);
            return lst.FirstOrDefault();
        }
    }
}
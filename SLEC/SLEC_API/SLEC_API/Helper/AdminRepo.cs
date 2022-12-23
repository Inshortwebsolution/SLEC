using SharedModel.Models;
using SLEC_API.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SLEC_API.Helper
{
    public class AdminRepo : IAdminRepo
    {
        IWSSLSEEntities db = new IWSSLSEEntities();
        public bool Approve(int? id)
        {
            bool result = false;
            try
            {
                var item = db.IWS_Student.Where(x => x.id == id).FirstOrDefault();
                item.isApprove = true;
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
                result = true;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

      
    }
}

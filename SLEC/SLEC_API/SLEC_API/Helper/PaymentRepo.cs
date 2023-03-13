using Newtonsoft.Json;
using SharedModel.Models;
using SLEC_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SLEC_API.Helper
{
    public class PaymentRepo : IPaymentRepo
    {
        IWSSLSEEntities db = new IWSSLSEEntities();

        public bool Delete(int id)
        {
            bool n = false;
            try
            {
                var item = db.IWS_Payment.Where(x => x.Payment_Id == id).FirstOrDefault();
                item.IsDelete = true;

                db.SaveChanges();
                n = true;
            }
            catch (Exception ex)
            {

                throw;
            }
            return n;
        }

        public List<Payment> GetAll()
        {
            List<Payment> lst = new List<Payment>();
            List<IWS_Payment> iwslst = new List<IWS_Payment>();
            iwslst = db.IWS_Payment.Where(x => x.IsActive== true && x.IsDelete == false).ToList();
            string json = JsonConvert.SerializeObject(iwslst);
            lst = JsonConvert.DeserializeObject<List<Payment>>(json);
            return lst;
        }

        public Payment GetById(int id)
        {
            Payment payment = new Payment();
            IWS_Payment iwspayment = new IWS_Payment();
            iwspayment = db.IWS_Payment.Where(x => x.Payment_Id == id && x.IsActive == true && x.IsDelete == false).FirstOrDefault();
            string json = JsonConvert.SerializeObject(iwspayment);
            payment = JsonConvert.DeserializeObject<Payment>(json);
            return payment;
        }

        public bool Save(Payment pay)
        {
            bool result = false;
            try
            {
             string json = JsonConvert.SerializeObject(pay);
                IWS_Payment Payment= JsonConvert.DeserializeObject<IWS_Payment>(json);
                Payment.IsActive = true;
                Payment.IsDelete = false;
                Payment.Created_Date =DateTime.Now;

                db.IWS_Payment.Add(Payment);
                db.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {

                throw;
            }
            return result;
        }

        public bool Update(Payment pay)
        {
            bool result = false;
            try
            {
                var item = db.IWS_Payment.Where(x => x.Payment_Id == pay.Payment_Id).FirstOrDefault();
                item.Pay_Method = pay.Pay_Method;
                item.Pay_Type = pay.Pay_Type;
                item.Amount = pay.Amount;
                item.course_id = pay.Course_id;
                item.Student_Id = pay.Student_Id;

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
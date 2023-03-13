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
    public class PaymentController : ApiController
    

    {

        IPaymentRepo IPay = new PaymentRepo();
        [Route("api/Payment/SavePayment")]
        [HttpPost]
        public HttpResponseMessage SavePayment(Payment pay)
        {
            Response response = new Response();
            try
            {

                bool n = IPay.Save(pay);
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

        [Route("api/Payment/Update")]
        [HttpPost]
        public HttpResponseMessage UpdatePayment(Payment pay)
        {
            Response response = new Response();
            try
            {

                bool n = IPay.Update(pay);
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

        [Route("api/Payment/GetAll")]
        [HttpGet]
        public HttpResponseMessage AllPayment()
        {
            Response response = new Response();
            List<Payment> lst = new List<Payment>();
            try
            {
                lst =IPay.GetAll();
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
        [Route("api/Payment/GePaymentById")]
        [HttpGet]

        
        public HttpResponseMessage GetPaymentById(int id)
        {
            Response response = new Response();
            Payment payment = new Payment();
            try
            {

                payment = IPay.GetById(id);
                if (payment != null)
                {
                    response.status = true;
                    response.data = payment;
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

        [Route("api/Payment/Delete")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            Response response = new Response();
            bool payment = false;
            try
            {

                payment = IPay.Delete(id);
                if (payment)
                {
                    response.status = true;
                    response.data = payment;
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

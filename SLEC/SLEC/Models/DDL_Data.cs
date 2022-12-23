using Newtonsoft.Json;
using SharedModel.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SLEC.Models
{
    public class DDL_Data
    {

        public List<SelectListItem> GetCourse()
        {
            // Api for List

            List<Course> lst = new List<Course>();
            try
            {
                System.Net.ServicePointManager.ServerCertificateValidationCallback = (senderX, certificate, chain, sslPolicyErrors) =>
                {
                    return true;
                };
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(ConfigurationManager.AppSettings["SLEC_APIurl"].ToString() + "Course/GetAll");
                httpWebRequest.ContentType = "text/json";
                httpWebRequest.Method = "GET";
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                string responseText = string.Empty;
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream())) { responseText = streamReader.ReadToEnd(); }
                Response responseResult = JsonConvert.DeserializeObject<Response>(responseText);
                if (responseResult.status)
                {
                    lst = JsonConvert.DeserializeObject<List<Course>>(responseResult.data.ToString());
                }

            }
            catch { }

            //Selected Single Text and Id For DropDown

            List<SelectListItem> item = lst.ConvertAll(a =>
            {
                return new SelectListItem()
                {
                    Text = a.add_coures,
                    Value = a.id.ToString(),
                    Selected = false
                };
            });
            return item;
        }
    }
}
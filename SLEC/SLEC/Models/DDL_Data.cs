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

        public List<SelectListItem> GetCategorie()
        {
            // Api for List

            List<Categorie> lst = new List<Categorie>();
            try
            {
                System.Net.ServicePointManager.ServerCertificateValidationCallback = (senderX, certificate, chain, sslPolicyErrors) =>
                {
                    return true;
                };
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(ConfigurationManager.AppSettings["SLEC_APIurl"].ToString() + "Categorie/GetAll");
                httpWebRequest.ContentType = "text/json";
                httpWebRequest.Method = "GET";
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                string responseText = string.Empty;
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream())) { responseText = streamReader.ReadToEnd(); }
                Response responseResult = JsonConvert.DeserializeObject<Response>(responseText);
                if (responseResult.status)
                {
                    lst = JsonConvert.DeserializeObject<List<Categorie>>(responseResult.data.ToString());
                    lst = lst.Where(x => x.p_id == 0).ToList();
                }

            }
            catch { }

           // Selected Single Text and Id For DropDown

            List<SelectListItem> item = lst.ConvertAll(a =>
            {
                return new SelectListItem()
                {
                    Text = a.category_name,
                    Value = a.id.ToString(),

                    Selected = false
                };
            });
            return item;
        }

        public List<SelectListItem> GetCategoriedropdown()
        {
            // Api for List

            List<Categorie> lst = new List<Categorie>();
            List<Categorie> lst01= new List<Categorie>();
            List<Categorie> lst02= new List<Categorie>();

            try
            {
                System.Net.ServicePointManager.ServerCertificateValidationCallback = (senderX, certificate, chain, sslPolicyErrors) =>
                {
                    return true;
                };
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(ConfigurationManager.AppSettings["SLEC_APIurl"].ToString() + "Categorie/GetAll");
                httpWebRequest.ContentType = "text/json";
                httpWebRequest.Method = "GET";
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                string responseText = string.Empty;
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream())) { responseText = streamReader.ReadToEnd(); }
                Response responseResult = JsonConvert.DeserializeObject<Response>(responseText);
                if (responseResult.status)
                {
                    lst = JsonConvert.DeserializeObject<List<Categorie>>(responseResult.data.ToString());
                    lst01 = lst.Where(x => x.p_id == 0).ToList();
                    List<int> ids = new List<int>();
                    ids = lst.Where(x => x.p_id == 0).Select(a => a.id).ToList();
                    lst02 = lst.Where(x => x.p_id != 0 && ids.Contains(x.p_id)).ToList();
                    //ids = lst.Where(x => x.p_id != 0 && ids.Contains(x.p_id)).Select(a => a.id).ToList();
                    //var subcat = lst.Where(x => x.p_id != 0 && ids.Contains(x.p_id)).ToList();


                }

            }
            catch { }

            // Selected Single Text and Id For DropDown

            List<SelectListItem> item = lst02.ConvertAll(a =>
            {
                return new SelectListItem()
                {
                    Text = a.category_name,
                    Value = a.id.ToString(),

                    Selected = false
                };
            });
            return item;
        }

        public List<SelectListItem> GetExam_Id()
        {
            // Api for List

            List<Exam> lst = new List<Exam>();
            try
            {
                System.Net.ServicePointManager.ServerCertificateValidationCallback = (senderX, certificate, chain, sslPolicyErrors) =>
                {
                    return true;
                };
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(ConfigurationManager.AppSettings["SLEC_APIurl"].ToString() + "Categorie/GetAllExam");
                httpWebRequest.ContentType = "text/json";
                httpWebRequest.Method = "GET";
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                string responseText = string.Empty;
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream())) { responseText = streamReader.ReadToEnd(); }
                Response responseResult = JsonConvert.DeserializeObject<Response>(responseText);
                if (responseResult.status)
                {
                    lst = JsonConvert.DeserializeObject<List<Exam>>(responseResult.data.ToString());
                }

            }
            catch { }

            //Selected Single Text and Id For DropDown

            List<SelectListItem> item = lst.ConvertAll(a =>
            {
                return new SelectListItem()
                {
                    Text = a.Exam_Title,
                    Value = a.Exam_Id.ToString(),
                    Selected = false
                };
            });
            return item;
        }

    }
}
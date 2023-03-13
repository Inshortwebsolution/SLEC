using SharedModel.Models;
using SLEC_API.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace SLEC.Controllers
{
    public class Current_ExamController : Controller
    {
        string apiurl = ConfigurationManager.AppSettings["SLEC_APIurl"].ToString();
        IWSSLSEEntities db = new IWSSLSEEntities();
        ICommonAPI api = new CommonAPI();
        // GET: Current_Exam
        public ActionResult StartExam()
        {
            return View();
        }
        public ActionResult HiddenStartExam()
        {
            return View();
        }

        public ActionResult ExamQUE()
        {
            return View();
        }

        public ActionResult PartialONQUE()
        {
            return View();
        }




        [HttpPost]
        public JsonResult Save_ExamHist(ExamHistory examHistory)
        {
            Response responseToView = new Response();
            string url = apiurl + "ExamManage/SaveExamHist";
            try
            {
                Response responseResult = api.Post(url, examHistory);
                if (responseResult.status)
                {
                    responseToView.status = true;
                    responseToView.data = responseResult.data;

                }
                else { responseToView.status = false; responseToView.error = responseResult.error; }
            }
            catch (Exception ex)
            {

                throw;
            }
            return Json(responseToView, JsonRequestBehavior.AllowGet); ;
        }

        public string RenderPartialToString(string partialViewName, object model)
        {
            InvalidateControllerContext();
            IView view = ViewEngines.Engines.FindPartialView(ControllerContext, partialViewName).View;
            string result = RenderViewToString(view, model);
            return result;
        }

        public string RenderViewToString(string viewName, object model)
        {
            InvalidateControllerContext();
            IView view = ViewEngines.Engines.FindView(ControllerContext, viewName, null).View;
            string result = RenderViewToString(view, model);
            return result;
        }

        public string RenderViewToString(IView view, object model)
        {
            InvalidateControllerContext();
            string result = null;
            if (view != null)
            {
                StringBuilder sb = new StringBuilder();
                using (StringWriter writer = new StringWriter(sb))
                {
                    ViewContext viewContext = new ViewContext(ControllerContext, view, new ViewDataDictionary(model), new TempDataDictionary(), writer);
                    view.Render(viewContext, writer);
                    writer.Flush();
                }
                result = sb.ToString();
            }
            return result;
        }

        private void InvalidateControllerContext()
        {
            if (ControllerContext == null)
            {
                ControllerContext context = new ControllerContext(System.Web.HttpContext.Current.Request.RequestContext, this);
                ControllerContext = context;
            }
        }
    }
}
using Newtonsoft.Json;
using SharedModel.Models;
using SLEC_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SLEC_API.Helper
{
    public class ExamManageRepo : IExamManageRepo
    {
        IWSSLSEEntities db = new IWSSLSEEntities();

        public List<Exam> GetAllExmTitle()
        {
            List<Exam> lst = new List<Exam>();
            List<IWS_Exam> iwslst = new List<IWS_Exam>();
            iwslst = db.IWS_Exam.Where(x => x.Isactive == true && x.Isdeleted == false).ToList();
            string json = JsonConvert.SerializeObject(iwslst);
            lst = JsonConvert.DeserializeObject<List<Exam>>(json);
            return lst;
        }

        public bool SaveExamHist(ExamHistory examHistory)
        {
            bool result = false;
            try
            {
                Random obj = new Random();
                var Attepted_Id= obj.Next(100, 99999999);
                string json = JsonConvert.SerializeObject(examHistory);
                IWS_Exam_Histroy ExamHistory = JsonConvert.DeserializeObject<IWS_Exam_Histroy>(json);
                ExamHistory.Attepted_Id = Attepted_Id;
                ExamHistory.IsActive = true;
                ExamHistory.Isdelete = false;
                ExamHistory.Created_By = 1;
                ExamHistory.Created = DateTime.Now;
                db.IWS_Exam_Histroy.Add(ExamHistory);

                db.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {

                throw;
            }

            return result;
        }

        public bool SaveExamLog(ExamLogin examLogin)
        {
            
                bool result = false;
                try
                {
                Random obj = new Random();
                var Userid = obj.Next(100, 99999);
                string json = JsonConvert.SerializeObject(examLogin);
                IWS_Exam_login Exam_Login = JsonConvert.DeserializeObject<IWS_Exam_login>(json);
                Exam_Login.IsActive = false;
                Exam_Login.IsDeleted = true;

                    db.IWS_Exam_login.Add(Exam_Login);
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

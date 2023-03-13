using Newtonsoft.Json;
using SharedModel.Models;
using SLEC_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SLEC_API.Helper
{
    public class CategorieRepo : ICategorieRepo
    {
        IWSSLSEEntities db = new IWSSLSEEntities();

        public List<Categorie> GetAll()
        {

            List<Categorie> lst = new List<Categorie>();
            List<IWS_Categories> iwslst = new List<IWS_Categories>();
            iwslst = db.IWS_Categories.Where(x => x.isactive == true && x.isdeleted == false).ToList();
            string json = JsonConvert.SerializeObject(iwslst);
            lst = JsonConvert.DeserializeObject<List<Categorie>>(json);

            return lst;

        }

        public bool SaveType(IWS_Categories categorie)
        {
            bool result = false;
            try
            {
                categorie.isactive = true;
                categorie.isdeleted = false;
                categorie.p_id = 0;
                categorie.created_date = DateTime.Now;
                db.IWS_Categories.Add(categorie);

                db.SaveChanges();
                result = true;
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }



        public bool SaveCategorie(IWS_Categories categorie)
        {
            bool result = false;
            try
            {

                categorie.isactive = true;
                categorie.isdeleted = false;
                categorie.created_date = DateTime.Now;
                db.IWS_Categories.Add(categorie);

                db.SaveChanges();
                result = true;
            }
            catch (Exception)
            {

                throw;
            }

            return result;

        }

        public bool Save_SubCategorie(IWS_Categories categorie)
        {
            bool result = false;
            try
            {

                categorie.isactive = true;
                categorie.isdeleted = false;
                categorie.p_id = categorie.p_id;
                categorie.category_name = categorie.category_name;
                categorie.created_date = DateTime.Now;
                db.IWS_Categories.Add(categorie);

                db.SaveChanges();
                result = true;
            }
            catch (Exception)
            {

                throw;
            }

            return result;

        }

        public List<Categorie> GetAllType()
        {

            List<Categorie> lst = new List<Categorie>();
            List<IWS_Categories> iwslst = new List<IWS_Categories>();
            iwslst = db.IWS_Categories.Where(x => x.isactive == true && x.isdeleted == false && x.p_id == 0).ToList();
            string json = JsonConvert.SerializeObject(iwslst);
            lst = JsonConvert.DeserializeObject<List<Categorie>>(json);

            return lst;
        }

        public bool UpdateType(Categorie categorie)
        {
            bool result = false;
            try
            {
                var item = db.IWS_Categories.Where(x => x.id == categorie.id).FirstOrDefault();
                item.category_name = categorie.category_name;

                db.SaveChanges();
                result = true;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public bool DeleteType(int id)
        {
            bool n = false;
            try
            {

                var item = db.IWS_Categories.Where(x => x.id == id).FirstOrDefault();
                item.isdeleted = true;

                db.SaveChanges();
                n = true;
            }
            catch (Exception ex)
            {

                throw;
            }
            return n;
        }

        public Categorie GetByIdtype(int id)
        {
            Categorie categorie = new Categorie();
            IWS_Categories iwscategorie = new IWS_Categories();
            iwscategorie = db.IWS_Categories.Where(x => x.id == id && x.isactive == true && x.isdeleted == false).FirstOrDefault();
            string json = JsonConvert.SerializeObject(iwscategorie);
            categorie = JsonConvert.DeserializeObject<Categorie>(json);
            return categorie;
        }

        public bool SaveExamTitle(IWS_Exam exam)
        {
            bool result = false;
            try
            {
                //string json = jsonconvert.serializeobject(exam);
                //iws_exam iws_student = jsonconvert.deserializeobject<iws_exam>(json);
                exam.Created_Date = DateTime.Now;
                exam.Created_By = 2;
                exam.Isactive = true;
                exam.Isdeleted = false;
                exam.Exam_Id = 2;
                exam.Updated_By = 5;
                exam.Updated_Date = DateTime.Now;



                db.IWS_Exam.Add(exam);
                db.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {

                var data=ex.Message;
            }
            return result;
        }

        public List<Exam> GetAllExam()
        {
          
                List<Exam> lst = new List<Exam>();
                List<IWS_Exam> iwslst = new List<IWS_Exam>();
                iwslst = db.IWS_Exam.Where(x => x.Isactive == true && x.Isdeleted == false).ToList();
                string json = JsonConvert.SerializeObject(iwslst);
                lst = JsonConvert.DeserializeObject<List<Exam>>(json);
                return lst;
            }

        public bool Save(Score score)
        {

            bool result = false;
            try
            {
                string json = JsonConvert.SerializeObject(score);
                IWS_Score Score = JsonConvert.DeserializeObject<IWS_Score>(json);
                score.IsActive = true;
                score.IsDeleted = false;
                score.Created_By = 1;
                score.Created_Date = DateTime.Now;
                db.IWS_Score.Add(Score);

                db.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {

                throw;
            }

            return result;
        }

        public bool Update(Score score)
        {

            bool result = false;
            try
            {
                var item = db.IWS_Score.Where(x => x.Question_NO==score.Question_NO).FirstOrDefault();
                item.Question_NO = score.Question_NO;
                item.Question = score.Question;
                item.Opction1 = score.Opction1;
                item.Opction1 = score.Opction2;
                item.Opction1 = score.Opction3;
                item.Opction1 = score.Opction4;
                item.IsActive = score.IsActive;
                item.IsDeleted = score.IsDeleted;
                item.Created_By= score.Created_By;
                item.Created_Date = score.Created_Date;
                item.Updated_By = score.Updated_By;
                item.Updated_Date = score.Updated_Date;
                db.SaveChanges();
                result = true;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public List<Score> GetAllScore()
        {
            List<Score> lst = new List<Score>();
            List<IWS_Score> iwslst = new List<IWS_Score>();
            iwslst = db.IWS_Score.Where(x => x.IsActive == true && x.IsDeleted == false).ToList();
            string json = JsonConvert.SerializeObject(iwslst);
            lst = JsonConvert.DeserializeObject<List<Score>>(json);
            return lst;
        }

        

        public Score GetById(int id)
        {
            Score score = new Score();
            IWS_Score iwsscore = new IWS_Score();
            iwsscore = db.IWS_Score.Where(x => x.Question_NO == id && x.IsActive == true && x.IsDeleted == false).FirstOrDefault();
            string json = JsonConvert.SerializeObject(iwsscore);
            score = JsonConvert.DeserializeObject<Score>(json);
            return score;
        }

        public bool DeleteScore(int id)
        {
            bool n = false;
            try
            {
                var item = db.IWS_Score.Where(x => x.Question_NO == id).FirstOrDefault();
                item.IsDeleted = true;

                db.SaveChanges();
                n = true;
            }
            catch (Exception ex)
            {

                throw;
            }
            return n;
        }

        public bool UpdateExam(Exam exam)
        {

            bool result = false;
            try
            {
                var item = db.IWS_Exam.Where(x => x.Exam_Id == exam.Exam_Id).FirstOrDefault();
                item.Exam_Title = exam.Exam_Title;
                item.Exam_Type = exam.Exam_Type;
                item.Num_Questions = exam.Num_Questions;
                item.Categorie = exam.Categorie;
                item.Sub_Categorie = exam.Sub_Categorie;
                item.Updated_By = exam.Updated_By;
                item.Updated_Date = exam.Updated_Date;
                
                db.SaveChanges();
                result = true;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public Exam GetByIdExam(int id)
        {
            Exam exam = new Exam();
            IWS_Exam iwsexam = new IWS_Exam();
            iwsexam = db.IWS_Exam.Where(x => x.Exam_Id == id && x.Isactive == true && x.Isdeleted == false).FirstOrDefault();
            string json = JsonConvert.SerializeObject(iwsexam);
            exam = JsonConvert.DeserializeObject<Exam>(json);
            return exam;
        }

        public bool DeleteExam_Title(int id)
        {
            bool n = false;
            try
            {
                var item = db.IWS_Exam.Where(x => x.Exam_Id == id).FirstOrDefault();
                item.Isdeleted = true;

                db.SaveChanges();
                n = true;
            }
            catch (Exception ex)
            {

                throw;
            }
            return n;
        }

        public bool UpdateCat(Categorie categorie)
        {
            bool result = false;
            try
            {
                var item = db.IWS_Categories.Where(x => x.id == categorie.id).FirstOrDefault();
                item.category_name = categorie.category_name;
                item.p_id = categorie.p_id;
                db.SaveChanges();
                result = true;
            }
            catch (Exception)
            {

                throw;
            }
            return result;

        }

        public bool UpdateSubCat(Categorie categorie)
        {
            bool result = false;
            try
            {
                var item = db.IWS_Categories.Where(x => x.id == categorie.id).FirstOrDefault();
                item.category_name = categorie.category_name;
                item.p_id = categorie.p_id;
                db.SaveChanges();
                result = true;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public Categorie GetCatById(int id)
        {
            Categorie categorie = new Categorie();
            IWS_Categories iwscategorie = new IWS_Categories();
            iwscategorie = db.IWS_Categories.Where(x => x.id == id && x.isactive == true && x.isdeleted == false).FirstOrDefault();
            string json = JsonConvert.SerializeObject(iwscategorie);
            categorie = JsonConvert.DeserializeObject<Categorie>(json);
            return categorie;
        }

        public Categorie GetSubCatById(int id)
        {
            Categorie categorie = new Categorie();
            IWS_Categories iwscategorie = new IWS_Categories();
            iwscategorie = db.IWS_Categories.Where(x => x.id == id && x.isactive == true && x.isdeleted == false).FirstOrDefault();
            string json = JsonConvert.SerializeObject(iwscategorie);
            categorie = JsonConvert.DeserializeObject<Categorie>(json);
            return categorie;
        }
    }
    }

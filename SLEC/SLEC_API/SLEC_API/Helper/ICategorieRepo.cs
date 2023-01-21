using SharedModel.Models;
using SLEC_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLEC_API.Helper
{
    public interface ICategorieRepo
    {
        bool SaveType(IWS_Categories categorie);
        bool SaveCategorie(IWS_Categories categorie);
        List<Categorie> GetAll();
        bool Save_SubCategorie(IWS_Categories categorie);
        List<Categorie> GetAllType();
        bool UpdateType(Categorie categorie);
        bool DeleteType(int id);
        Categorie GetByIdtype(int id);
        bool SaveExamTitle(IWS_Exam exam);
        List<Exam> GetAllExam();
        bool Save(Score score);
        bool Update(Score score);
       
        Score GetById(int id);
        List<Score> GetAllScore();
        bool DeleteScore(int id);
        bool UpdateExam(Exam exam);
        Exam GetByIdExam(int id);
        bool DeleteExam_Title(int id);
    }
}

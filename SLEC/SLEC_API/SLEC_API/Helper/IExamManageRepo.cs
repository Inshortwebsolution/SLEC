using SharedModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLEC_API.Helper
{
    public interface IExamManageRepo
    {
        bool SaveExamLog(ExamLogin examLogin);
        List<Exam> GetAllExmTitle();
        bool SaveExamHist(ExamHistory examHistory);
    }
}

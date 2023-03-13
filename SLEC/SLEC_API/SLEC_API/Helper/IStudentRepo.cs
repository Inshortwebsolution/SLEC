using SharedModel.Models;
using SLEC_API.Models;
using System.Collections.Generic;

namespace SLEC_API.Helper
{
    public interface IStudentRepo
    {
        List<Student> GetAll();
       bool WaitngApprovel(int? id);
        bool SaveStudent(IWS_Student student);
        Student GetById(int id);
        bool Update(Student student);
        bool Delete(int id);
        bool Approve(int? id);
        List<Student> GetAllApprovedStudent();
        bool SendForApprove(int? id);
        Student GetDetailById(int id);
        Student GetDetailByNameYear(string name,string year);
        bool UpdateStatus(int id,string status);
        Student GetDetailByEmail(string email);
        Student GetDetailBy_userid(int userid);
        bool RequestExam(int id);
    }
}
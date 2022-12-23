using SharedModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLEC_API.Helper
{
    interface ICourseRepo
    {
        List<Course> GetAll();
        bool SaveCourses(Course course);
        Course GetById(int id);
        bool Update(Course course);
        bool Delete(int id);
    }
}

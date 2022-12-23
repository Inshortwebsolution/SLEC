using SharedModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLEC_API.Helper
{
    interface IInstituteRepo
    {
        bool Save(Institute inst);
        List<Institute> GetAll();
        Institute GetById(int id);
        bool Update(Institute inst);
        bool Delete(int id);
    }
}

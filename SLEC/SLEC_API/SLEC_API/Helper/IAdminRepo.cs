using SharedModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLEC_API.Helper
{
    public interface IAdminRepo
    {
        bool Approve(int? id);
        
    }
}

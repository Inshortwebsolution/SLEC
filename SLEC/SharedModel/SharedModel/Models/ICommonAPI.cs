using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModel.Models
{
    public interface ICommonAPI
    {
        Response Post(string v, object institute);
        Response Get(string url);
       
    }
}

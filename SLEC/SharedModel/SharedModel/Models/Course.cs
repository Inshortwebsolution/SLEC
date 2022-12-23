using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModel.Models
{
     public class Course
    {
        public int id { get; set; }
        public string add_coures { get; set; }
        public string duration { get; set; }
        public int fees { get; set; }
        public bool isactive { get; set; }
        public bool isdeleted { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModel.Models
{
    public class Login
    {
        public int id { get; set; }
        public string password { get; set; }
        public string type { get; set; }
        public bool? isactive { get; set; }
        public bool? isdeleted { get; set; }
        public int created_by { get; set; }
        public DateTime? created_date { get; set; }
        public int? updated_by { get; set; }
        public DateTime? updated_date { get; set; }
        public string username { get; set; }

    }
}

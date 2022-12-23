using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModel.Models
{
    
    
        public class Institute
        {
            public string name { get; set; }
            public string mobile { get; set; }
            public string Email { get; set; }
            public string password { get; set; }
            public string Address { get; set; }
            public string YourEducation { get; set; }
            public string Institute_type { get; set; }
            public string Present_job_profession { get; set; }
            public string Education_Sector_Experience { get; set; }
            public string Your_Comment_query { get; set; }
            public DateTime? createdone { get; set; }
            public string createdby { get; set; }
            public bool isActive { get; set; }
            public bool isdeleted { get; set; }
            public DateTime? updatedon { get; set; }
            public string opdatedby { get; set; }
            public int id { get; set; }
            public string Institute_Pre_School { get; set; }
            public bool isapprove { get; set; }

        }
    }


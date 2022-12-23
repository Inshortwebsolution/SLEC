using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModel.Models
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string f_name { get; set; }
        public string m_name { get; set; }
        public string lst_class { get; set; }
        public DateTime? dob { get; set; }
        public string course_name { get; set; }
        public string cast { get; set; }
        public string religion { get; set; }
        public string address { get; set; }
        public long aadhar_NO { get; set; }
        public long whats_no_self { get; set; }
        public long whats_no_home { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public long refid { get; set; }
        public string images { get; set; }
        public string img_sing { get; set; }
        public bool? isdeleted { get; set; }
        public bool? isactive { get; set; }
        public int created_by { get; set; }
        public DateTime? created_date { get; set; }
        public int updated_by { get; set; }
        public DateTime? updated_date { get; set; }
        public int institute_id { get; set; }
        public bool isOnline { get; set; }
        public bool isApprove { get; set; }
        public string Year { get; set; }
        public string Status { get; set; }
    }
}

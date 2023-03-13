using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModel.Models
{
     public class Payment
    {

        public int Payment_Id { get; set; }

        public DateTime? Pay_Date { get; set; }
        public string Pay_Method { get; set; }
        public string Pay_Type { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public int? Created_By { get; set; }
        public DateTime? Created_Date { get; set; }
       
        public int? Updated_By { get; set; }
        public DateTime? Updated_Date { get; set; }
        public int? Student_Id { get; set; }
        public int? Course_id { get; set; }
        public int? Amount { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModel.Models
{
     public class Exam
    {

	    public string Exam_Type { get; set; }
        public int Exam_Id { get; set; }
		public string Exam_Title { get; set; }
		public string Categorie { get; set; }
        public string Sub_Categorie { get; set; }
        public int? Num_Questions { get; set; }
		public  string Is_Optional { get; set; }
		public string Is_True_orFalse { get; set; }
		public bool? Isactive { get; set; }
		public bool? Isdeleted { get; set; }
		public int? Created_By { get; set; }
		public DateTime? Created_Date { get; set; }
		public int? Updated_By { get; set; }
		public DateTime? Updated_Date { get; set; }
	}
}

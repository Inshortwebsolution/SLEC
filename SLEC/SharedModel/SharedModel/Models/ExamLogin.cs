using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModel.Models
{
     public class ExamLogin
    {
		public int Id { get; set; }
		public int User_Id { get; set; }
		public int? Exam_Id { get; set; }
		public int Student_Id { get; set; }
		public string Status { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public bool? IsActive { get; set; }
		public bool? IsDeleted { get; set; }
		public int? Created_By { get; set; }
		public DateTime? Created { get; set; }
		public int? Updated_By { get; set; }
		public DateTime? Updated { get; set; }
		public int? MOb_NO { get; set; }
		public DateTime? DOB { get; set; }
	}
}

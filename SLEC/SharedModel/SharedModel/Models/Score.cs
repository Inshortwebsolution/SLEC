using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModel.Models
{
    
     public class Score
    {
		public int Exam_id { get; set; }
		public int Question_NO { get; set; }
		public string Question { get; set; }
		public string Opction1 { get; set; }
		public string Opction2 { get; set; }
		public string Opction3 { get; set; }
		public string Opction4 { get; set; }
		public string Answer { get; set; }
		public bool IsActive { get; set; }
		public bool IsDeleted { get; set; }
		public DateTime Created_Date { get; set; }
        public int Created_By { get; set; }
		public int Updated_By { get; set; }
		public DateTime Updated_Date { get; set; }
		public int Id { get; set; }
	}
}

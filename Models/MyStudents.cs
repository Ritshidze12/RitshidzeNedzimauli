using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RitshidzeNedzimauliStudyGroup.Models
{
	public class MyStudents
	{
		[Display(Name = "Sudent Number")]
		public string StudentNumber { get; set; }

		[Display(Name = "First Name")]
		public string FirstName { get; set; }

		[Display(Name= "Surname")]
		public string surname { get; set; }

		[Display(Name = "Email")]
		public string email { get; set; }
	}
}
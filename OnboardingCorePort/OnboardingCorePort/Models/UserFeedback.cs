using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnboardingCorePort.Models
{
	public class UserFeedback
	{
		[Key]
		public int UserFeedbackID { get; set; }

		public int UserID { get; set; }
		public User User { get; set; }

		public int CategoryID { get; set; }
		public Category Category { get; set; }

		public int LevelSatisfiedID { get; set; }
		public LevelSatisfied LevelSatisfied { get; set; }

		public string Comments { get; set; }

		public DateTime? Timestamp { get; set; }

	}
}

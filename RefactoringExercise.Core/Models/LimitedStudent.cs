using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringExercise.Core.Models
{
	public abstract class LimitedStudent : Student
	{
		public LimitedStudent(string emailAddress, Guid universityId)
			: base(emailAddress, universityId)
		{

		}
		public abstract void AddBonusAllowance();
	}
}

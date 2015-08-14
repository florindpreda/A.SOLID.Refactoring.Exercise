using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringExercise
{
	public class UnlimitedStudent: Student
	{
		public UnlimitedStudent(string emailAddress, Guid universityId)
			: base(emailAddress, universityId)
		{
			this.MonthlyEbookAllowance = 0;
		}		
	}
}

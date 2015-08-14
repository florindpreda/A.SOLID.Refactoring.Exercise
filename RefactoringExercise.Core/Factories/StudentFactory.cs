using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringExercise
{
	public class StudentFactory : IStudentFactory
	{
		public Student Create(string emailAddress, Guid universityId, Package package)
		{
			switch(package)
			{
				case Package.Standard: return new StandardStudent(emailAddress, universityId); break;
				case Package.Premium: return new PremiumStudent(emailAddress, universityId); break;
				default: throw new NotImplementedException("There is no associated student for this package");
			}
		}
	}
}

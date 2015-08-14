using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringExercise
{
	public class StudentReaderService: IStudentReaderService
	{
		//...		
		public IEnumerable<Student> GetStudentsByUniversity()
		{
			//...
			throw new NotImplementedException();
		}

		public IEnumerable<Student> GetStudentsByCurrentlyBorrowedEbooks()
		{
			//...
			throw new NotImplementedException();
		}
	}
}
using RefactoringExercise.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringExercise
{
	public class StudentRepository : IStudentRepository
	{
		public void Add(Student student)
		{
			throw new NotImplementedException();
		}
		public bool Exists(string emailAddress)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<LimitedStudent> GetStudentsForAllowanceIncrease()
		{
			throw new NotImplementedException();
		}
	}
}

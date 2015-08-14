using RefactoringExercise.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefactoringExercise
{
	public interface IStudentRepository
	{
		void Add(Student student);
		bool Exists(string emailAddress);
		IEnumerable<LimitedStudent> GetStudentsForAllowanceIncrease();
	}
}

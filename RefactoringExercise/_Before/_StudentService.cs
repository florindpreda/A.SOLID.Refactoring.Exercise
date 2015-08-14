using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringExercise
{
	public class _StudentService
	{
		public bool Add(string emailAddress, Guid universityId)
		{
			//SRP
			Console.WriteLine(string.Format("Log: Start add student with email '{0}'", emailAddress));

			if (string.IsNullOrWhiteSpace(emailAddress))//input validation
			{
				return false;
			}

			var studentRepository = new _StudentRepository();//DIP

			if (studentRepository.Exists(emailAddress))//domain validation
			{
				return false;
			}

			var universityRepository = new _UniversityRepository();

			var university = universityRepository.GetById(universityId);

			var student = new _Student(emailAddress, universityId);
			
			//SRP, OCP
			if (university.Package == _Package.Standard)
			{
				student.MonthlyEbookAllowance = 10;
			}
			else if (university.Package == _Package.Premium)
			{
				student.MonthlyEbookAllowance = 10 * 2;
			}							
			
			studentRepository.Add(student);

			//SRP
			Console.WriteLine(string.Format("Log: End add student with email '{0}'", emailAddress));

			return true;//CQS
		}

		//ISP
		public IEnumerable<_Student> GetStudentsByUniversity()
		{
			//...
			throw new NotImplementedException();
		}

		public IEnumerable<_Student> GetStudentsByCurrentlyBorrowedEbooks()
		{
			//...
			throw new NotImplementedException();
		}
	}
}

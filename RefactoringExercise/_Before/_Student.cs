using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefactoringExercise
{
	public class _Student
	{
		public string EmailAddress { get; private set; }
		public Guid UniversityId { get; private set; }
		public int MonthlyEbookAllowance { get; set; }
		public int CurrentlyBorrowedEbooks { get; private set; }

		public _Student(string emailAddress, Guid universityId)
		{
			this.EmailAddress = emailAddress;
			this.UniversityId = universityId;
		}		
	}
}

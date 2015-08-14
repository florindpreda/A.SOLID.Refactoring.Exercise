using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefactoringExercise
{
	public interface IUniversityRepository
	{
		University GetById(Guid universityId);
	}
}
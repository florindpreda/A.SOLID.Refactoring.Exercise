using RefactoringExercise.Core.Exceptions;
using RefactoringExercise.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringExercise
{
	public class StudentWriterService: IStudentWriterService
	{
		private readonly IStudentRepository _studentRepository;
		private readonly IUniversityRepository _universityRepository;
		private readonly ILogger _logger;
		private readonly IStudentFactory _studentFactory;

		public StudentWriterService(IStudentRepository studentRepository, IUniversityRepository universityRepository, ILogger logger, IStudentFactory studentFactory)
		{
			_studentRepository = studentRepository;
			_universityRepository = universityRepository;
			_logger = logger;
			_studentFactory = studentFactory;
		}

		public void Add(string emailAddress, Guid universityId)
		{			
			_logger.Log(string.Format("Log: Start add student with email '{0}'", emailAddress));			

			if (_studentRepository.Exists(emailAddress))
			{
				throw new DomainException("A user with the same e-mail address already exists.");
			}

			var university = _universityRepository.GetById(universityId);
			
			var student = _studentFactory.Create(emailAddress, universityId, university.Package);			
			
			_studentRepository.Add(student);
			
			_logger.Log(string.Format("Log: End add student with email '{0}'", emailAddress));			
		}
		
		public void AddBonusAllowances()
		{			
			var students = _studentRepository.GetStudentsForAllowanceIncrease();
			foreach(LimitedStudent s in students)
			{				
				s.AddBonusAllowance();
			}			
		}		
	}
}

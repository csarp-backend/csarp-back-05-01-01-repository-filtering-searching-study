﻿using Kreta.Backend.Context;
using Kreta.Shared.Models;
using Kreta.Shared.Parameters;
using Kreta.Shared.Responses;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos
{
    public class StudentRepo<TDbConstext> : RepositoryBase<TDbConstext, Student>, IStudentRepo
        where TDbConstext : DbContext
    {
        public StudentRepo(IDbContextFactory<TDbConstext> dbContextFactory) : base(dbContextFactory)
        {
        }

        public IQueryable<Student> GetStudents(StudentQueryParameters parameters)
        {
            IQueryable<Student> filteredStudent = FindByCondition(student => student.BirthDay.Year >= parameters.MinYearOfBirth
                                           && student.BirthDay.Year <= parameters.MaxYearOfBirth
                                  )
                                  .OrderBy(student => student.HungarianFullName);
            
            SearchByStudentName(ref filteredStudent, parameters.Name);
            return filteredStudent;

        }

        private void SearchByStudentName(ref IQueryable<Student> students, string studentName)
        {
            if (!students.Any() || string.IsNullOrEmpty(studentName))
            {
                return;
            }
            students = students.Where(student => student.HungarianFullName.ToLower().Contains(studentName.Trim().ToLower()));
        }

    }
}

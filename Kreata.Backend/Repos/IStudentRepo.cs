﻿using Kreta.Shared.Models;
using Kreta.Shared.Parameters;

namespace Kreta.Backend.Repos
{
    public interface IStudentRepo : IRepositoryBase<Student>
    {
        public IQueryable<Student> GetStudents(StudentQueryParameters parameters);
    }
}

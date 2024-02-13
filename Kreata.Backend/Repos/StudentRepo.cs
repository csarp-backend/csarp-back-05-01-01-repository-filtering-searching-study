using Kreta.Backend.Context;
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
            return FindByCondition(student => student.BirthDay.Year >= parameters.MinYearOfBirth
                                           && student.BirthDay.Year <= parameters.MaxYearOfBirth
                                  )
                                  .OrderBy(student => student.HungarianFullName);
        }
    }
}

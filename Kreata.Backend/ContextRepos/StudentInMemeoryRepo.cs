using Kreta.Backend.Context;
using Kreta.Backend.Repos;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.ContextRepos
{
    public class StudentInMemoryRepo : StudentRepo<KretaInMemoryContext>, IStudentRepo
    {
        public StudentInMemoryRepo(IDbContextFactory<KretaInMemoryContext> dbContextFactory) : base(dbContextFactory)
        {
        }
    }
}

using GenericRepositoryExampla.Entities.Model;
using GenericRepositoryExampla.Entities.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExample.DataAccsess.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(GenericDbContext context):base(context){}
        public async Task<IEnumerable<User>> GetAllWithProfileAsync()
        {
            return (IEnumerable<User>)await GenericDbContext.User.Include(a=>a.Profiles).SingleOrDefaultAsync();
        }
        private GenericDbContext GenericDbContext
        {
            get { return Context as GenericDbContext; }
        }
    }
}

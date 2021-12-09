using GenericRepositoryExampla.Entities.Model;
using GenericRepositoryExampla.Entities.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExample.DataAccsess.Repositories
{
    public class ProfileRepository : Repository<Profile>, IProfileRepository
    {
        public ProfileRepository(GenericDbContext context) : base(context) { }
        public async Task<Profile> GetWithUserByIdAsync(int id)
        {
            return await GenericDbContext.Profiles.Include(w => w.User).SingleOrDefaultAsync(w => w.Profil_Id == id);
        }

    

        public async Task<IEnumerable<Profile>> GetAllWithUserAsync()
        {
            return await GenericDbContext.Profiles.ToListAsync();
        }

        private GenericDbContext GenericDbContext
        {
            get { return Context as GenericDbContext; }
        }
    }
}

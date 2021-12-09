using GenericRepositoryExampla.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExampla.Entities.Repositories
{
    public interface IProfileRepository : IRepository<Profile>
    {
        Task<Profile> GetWithUserByIdAsync(int id);
        Task<IEnumerable<Profile>> GetAllWithUserAsync();
    }
}

using GenericRepositoryExampla.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExampla.Entities.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        //tüm kullanıcıları listelemek istersem
        Task<IEnumerable<User>> GetAllWithProfileAsync();

    }
}

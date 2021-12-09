using GenericRepositoryExampla.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExampla.Entities.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
      
        Task<IEnumerable<Category>> GetAllWithContentAsync();
    }
}

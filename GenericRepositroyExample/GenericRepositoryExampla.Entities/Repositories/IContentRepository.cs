using GenericRepositoryExampla.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExampla.Entities.Repositories
{
    public interface IContentRepository : IRepository<Content>
    {

        Task<Content> GetWithCategoryByIdAsync(int id);
        Task<IEnumerable<Content>> GetAllWithCategoryAsync();
    }
}

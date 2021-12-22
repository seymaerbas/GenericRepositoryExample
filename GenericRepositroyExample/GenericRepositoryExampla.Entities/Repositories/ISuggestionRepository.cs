using GenericRepositoryExampla.Entities.Repositories;
using GenericRepositoryExampla.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExampla.Entity.Repositories
{
    public interface ISuggestionRepository : IRepository<Suggestion>
    {
        Task<Suggestion> GetWithUserByIdAsync(int id);
    }
}


using GenericRepositoryExampla.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExample.Business.Abstract
{
   public interface ISuggestionServices
    {
        Task<IEnumerable<Suggestion>> GetAllSuggestions();
        Task<Suggestion> GetSuggestionById(int id);
        Task<Suggestion> CreateSuggestion(Suggestion suggestion);
        Task UpdateSuggestion(Suggestion suggestionToBeUpdate, Suggestion suggestion);
        Task DeleteSuggestion(Suggestion suggestion);
    }
}


using GenericRepositoryExampla.Entities.Repositories;
using GenericRepositoryExampla.Entity.Model;
using GenericRepositoryExample.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExample.Business.Concrete
{
    public class SuggestionServices : ISuggestionServices
    {
        private IUnitOfWork _unitOfWork;
        public SuggestionServices(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public async Task<Suggestion> CreateSuggestion(Suggestion suggestion)
        {
            await _unitOfWork.Suggestion.AddAsync(suggestion);
            return suggestion;
        }

        public async Task DeleteSuggestion(Suggestion suggestion)
        {
            _unitOfWork.Suggestion.Remove(suggestion);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Suggestion>> GetAllSuggestions()
        {
            return await _unitOfWork.Suggestion.GetAllAsync();
        }

        public async Task<Suggestion> GetSuggestionById(int id)
        {
            return await _unitOfWork.Suggestion.GetByIdAsync(id);
        }

        public async Task UpdateSuggestion(Suggestion suggestionToBeUpdate, Suggestion suggestion)
        {
            suggestionToBeUpdate.Title = suggestion.Title;
            await _unitOfWork.CommitAsync();
        }
    }
}

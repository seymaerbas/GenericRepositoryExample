using GenericRepositoryExampla.Entities.Model;
using GenericRepositoryExampla.Entities.Repositories;
using GenericRepositoryExample.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExample.Business.Concrete
{
    public class CategoryServices : ICategoryServices
    {
        private IUnitOfWork _unitOfWork;
        public CategoryServices(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public async Task<Category> CreateCategory(Category category)
        {
            await _unitOfWork.Categories.AddAsync(category);
            return category;
        }

        public async Task DeleteCategory(Category category)
        {
            _unitOfWork.Categories.Remove(category);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Category>> GetAllCategory()
        {
            return await _unitOfWork.Categories.GetAllAsync();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await _unitOfWork.Categories.GetByIdAsync(id);
        }

        public async Task UpdateCategory(Category categoryToBeUpdate, Category category)
        {
            categoryToBeUpdate.Title = category.Title;
            await _unitOfWork.CommitAsync();
        }
    }
}

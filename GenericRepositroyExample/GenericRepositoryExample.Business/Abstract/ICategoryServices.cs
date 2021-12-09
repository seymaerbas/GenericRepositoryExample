using GenericRepositoryExampla.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExample.Business.Abstract
{
   public interface ICategoryServices
    {
        Task<IEnumerable<Category>> GetAllCategory(); //tüm profilleri getir
        Task<Category> GetCategoryById(int id); //idsi ? olan profili getir
        Task<Category> CreateCategory(Category category); //entity
        Task UpdateCategory(Category categoryToBeUpdate, Category category);
        Task DeleteCategory(Category category);
    }
}

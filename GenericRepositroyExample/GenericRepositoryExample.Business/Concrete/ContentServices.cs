using GenericRepositoryExampla.Entities.Model;
using GenericRepositoryExampla.Entities.Repositories;
using GenericRepositoryExample.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExample.Business.Concrete
{
    public class ContentServices : IContentServices
    {
        private IUnitOfWork _unitOfWork;
        public ContentServices(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public async Task<Content> CreateContent(Content content)
        {
            await _unitOfWork.Contents.AddAsync(content);
            return content;
        }

        public async Task DeleteContent(Content content)
        {
            _unitOfWork.Contents.Remove(content);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Content>> GetAllContent()
        {
            return await _unitOfWork.Contents.GetAllAsync();
        }

        public async Task<Content> GetContentById(int id)
        {
            return await _unitOfWork.Contents.GetByIdAsync(id);
        }

        public async Task UpdateContent(Content contentToBeUpdate, Content content)
        {
            contentToBeUpdate.Title = content.Title;
            await _unitOfWork.CommitAsync();
        }
    }
}

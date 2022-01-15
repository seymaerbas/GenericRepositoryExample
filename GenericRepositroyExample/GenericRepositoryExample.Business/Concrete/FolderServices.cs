
using GenericRepositoryExampla.Entities.Repositories;
using GenericRepositoryExampla.Entity.Model;
using GenericRepositoryExample.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExample.Business.Concrete
{
    public class FolderServices :IFolderServices
    {
        private IUnitOfWork _unitOfWork;
        public FolderServices(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<Folder> CreateFolder(Folder folder)
        {
            await _unitOfWork.Folder.AddAsync(folder);
            return folder;
        }

        public async Task DeleteFolder(Folder folder)
        {
            _unitOfWork.Folder.Remove(folder);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Folder>> GetAllFolder()
        {
            return await _unitOfWork.Folder.GetAllAsync();
        }

        public async Task<Folder> GetFolderById(int id)
        {
            return await _unitOfWork.Folder.GetByIdAsync(id);
        }

        public async Task UpdateFolder(Folder folderToBeUpdate, Folder folder)
        {
            folderToBeUpdate.Type = folder.Type;
            await _unitOfWork.CommitAsync();
        }
    }
}

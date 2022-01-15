
using GenericRepositoryExampla.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExample.Business.Abstract
{
    public interface IFolderServices
    {
        Task<IEnumerable<Folder>> GetAllFolder();
        Task<Folder> GetFolderById(int id);
        Task<Folder> CreateFolder(Folder folder);
        Task UpdateFolder(Folder folderToBeUpdate, Folder folder);
        Task DeleteFolder(Folder folder);
    }
}

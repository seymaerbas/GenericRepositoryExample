
using GenericRepositoryExampla.Entities.Repositories;
using GenericRepositoryExampla.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExampla.Entity.Repositories
{
    public interface IFolderRepository : IRepository<Folder>
    {
        Task<Folder> GetWithUserByIdAsync(int id);
    }
}

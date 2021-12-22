
using GenericRepositoryExampla.Entity.Model;
using GenericRepositoryExampla.Entity.Repositories;
using GenericRepositoryExample.DataAccsess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExampla.DataAcces.Repositories
{
    public class FolderRepository : Repository<Folder>, IFolderRepository
    {
        public FolderRepository(GenericDbContext context) : base(context) { }
        private GenericDbContext GenericDbContext
        {
            get { return Context as GenericDbContext; }
        }
        public async Task<Folder> GetWithUserByIdAsync(int id)
        {
            return await GenericDbContext.Folders.Include(w => w.User).SingleOrDefaultAsync(w => w.Folder_Id == id);
        }
    }
}

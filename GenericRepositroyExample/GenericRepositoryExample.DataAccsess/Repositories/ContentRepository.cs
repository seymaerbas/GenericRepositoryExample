using GenericRepositoryExampla.Entities.Model;
using GenericRepositoryExampla.Entities.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExample.DataAccsess.Repositories
{
    public class ContentRepository : Repository<Content>, IContentRepository
    {
        public ContentRepository(GenericDbContext context) : base(context) { }
      
        private GenericDbContext GenericDbContext
        {
            get { return Context as GenericDbContext; }
        }

        public async Task<IEnumerable<Content>> GetAllWithCategoryAsync()
        {
            return await GenericDbContext.Contents.ToListAsync();
        }

        public async Task<Content> GetWithCategoryByIdAsync(int id)
        {
            return await GenericDbContext.Contents.Include(w => w.Category).SingleOrDefaultAsync(w => w.Content_Id == id);
        }
    }
}

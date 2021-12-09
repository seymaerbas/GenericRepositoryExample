using GenericRepositoryExampla.Entities.Model;
using GenericRepositoryExampla.Entities.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExample.DataAccsess.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(GenericDbContext context) : base(context) { }
        public async Task<IEnumerable<Category>> GetAllWithContentAsync()
        {
            return (IEnumerable<Category>)await GenericDbContext.Categories.Include(a => a.Contents).SingleOrDefaultAsync();
        }

        private GenericDbContext GenericDbContext
        {
            get { return Context as GenericDbContext; }
        }
    }
}

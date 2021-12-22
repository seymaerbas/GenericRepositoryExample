
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
    public class SuggestionRepository : Repository<Suggestion>, ISuggestionRepository
    {
        public SuggestionRepository(GenericDbContext context) : base(context) { }
        public async Task<Suggestion> GetWithUserByIdAsync(int id)
        {
            return await GenericDbContext.Suggestions.Include(w => w.User).SingleOrDefaultAsync(w => w.Suggestion_Id == id);

        }
        private GenericDbContext GenericDbContext
        {
            get { return Context as GenericDbContext; }
        }
    }
}

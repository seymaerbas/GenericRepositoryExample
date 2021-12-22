
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
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        public CommentRepository(GenericDbContext context) : base(context) { }
        private GenericDbContext GenericDbContext
        {
            get { return Context as GenericDbContext; }
        }
        public async Task<Comment> GetWithUserByIdAsync(int id)
        {
            return await GenericDbContext.Comments.Include(w => w.User).SingleOrDefaultAsync(w => w.Comment_Id == id);
        }
    }
}

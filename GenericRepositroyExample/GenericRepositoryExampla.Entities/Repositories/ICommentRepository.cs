
using GenericRepositoryExampla.Entities.Repositories;
using GenericRepositoryExampla.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExampla.Entity.Repositories
{
    public interface ICommentRepository : IRepository<Comment>
    {
        Task<Comment> GetWithUserByIdAsync(int id);
    }
}

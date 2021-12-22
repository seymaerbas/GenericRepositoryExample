
using GenericRepositoryExampla.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExample.Business.Abstract
{
    public interface ICommentServices
    {
        Task<IEnumerable<Comment>> GetAllComments();
        Task<Comment> GetCommentById(int id);
        Task<Comment> CreateComment(Comment comment);
        Task UpdateComment(Comment commentToBeUpdate, Comment comment);
        Task DeleteComment(Comment comment);
    }
}

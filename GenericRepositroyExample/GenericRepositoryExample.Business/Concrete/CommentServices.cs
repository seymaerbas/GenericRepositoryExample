
using GenericRepositoryExampla.Entities.Repositories;
using GenericRepositoryExampla.Entity.Model;
using GenericRepositoryExample.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExample.Business.Concrete
{
   public class CommentServices :ICommentServices
    {
        private IUnitOfWork _unitOfWork;
        public CommentServices(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<Comment> CreateComment(Comment comment)
        {
            await _unitOfWork.Comment.AddAsync(comment);
            return comment;
        }

        public async Task DeleteComment(Comment comment)
        {
            _unitOfWork.Comment.Remove(comment);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Comment>> GetAllComments()
        {
            return await _unitOfWork.Comment.GetAllAsync();
        }

        public async Task<Comment> GetCommentById(int id)
        {
            return await _unitOfWork.Comment.GetByIdAsync(id);
        }

        public async Task UpdateComment(Comment commentToBeUpdate, Comment comment)
        {
            commentToBeUpdate.CommentDetail = comment.CommentDetail;
            await _unitOfWork.CommitAsync();
        }
    }
}

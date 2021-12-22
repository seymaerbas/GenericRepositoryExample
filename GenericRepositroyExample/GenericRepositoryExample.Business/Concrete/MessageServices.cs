using GenericRepositoryExampla.Entities.Repositories;
using GenericRepositoryExampla.Entity.Model;
using GenericRepositoryExample.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExample.Business.Concrete
{
    public class MessageServices :IMessageServices
    {
        private IUnitOfWork _unitOfWork;
        public MessageServices(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<Message> CreateMessage(Message message)
        {
            await _unitOfWork.Message.AddAsync(message);
            return message;
        }

        public async Task DeleteMessage(Message message)
        {
            _unitOfWork.Message.Remove(message);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Message>> GetAllMessages()
        {
            return await _unitOfWork.Message.GetAllAsync();
        }

        public async Task<Message> GetMessageById(int id)
        {
            return await _unitOfWork.Message.GetByIdAsync(id);
        }

        public async Task UpdateMessage(Message messageToBeUpdate, Message message)
        {
            messageToBeUpdate.Subject = message.Subject;
            await _unitOfWork.CommitAsync();
        }
    }
}

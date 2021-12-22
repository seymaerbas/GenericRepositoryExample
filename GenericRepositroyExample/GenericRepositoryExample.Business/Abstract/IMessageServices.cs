
using GenericRepositoryExampla.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExample.Business.Abstract
{
    public interface IMessageServices
    {
        Task<IEnumerable<Message>> GetAllMessages();
        Task<Message> GetMessageById(int id);
        Task<Message> CreateMessage(Message message);
        Task UpdateMessage(Message messageToBeUpdate, Message message);
        Task DeleteMessage(Message message);
    }
}

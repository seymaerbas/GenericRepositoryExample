using GenericRepositoryExampla.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExample.Business.Abstract
{
   public interface IUserServices
    {
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUserById(int id);
        Task<User> CreateUser(User user);
        Task UpdateUser(User userToBeUpdate, User user);
        Task DeleteUser(User user);
    }
}

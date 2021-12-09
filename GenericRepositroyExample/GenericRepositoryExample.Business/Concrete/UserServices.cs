using GenericRepositoryExampla.Entities.Model;
using GenericRepositoryExampla.Entities.Repositories;
using GenericRepositoryExample.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExample.Business.Concrete
{
    public class UserServices : IUserServices
    {
        private IUnitOfWork _unitOfWork;
        public UserServices(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        //context nesnesi artık unitofworktür
        public async Task<User> CreateUser(User user)
        {
            await _unitOfWork.Users.AddAsync(user);
            return user;

        }

        public async Task DeleteUser(User user)
        {
            _unitOfWork.Users.Remove(user);
            await _unitOfWork.CommitAsync();
        }

       

        public async Task<User> GetUserById(int id)
        {
            return await _unitOfWork.Users.GetByIdAsync(id);
        }

        public async Task UpdateUser(User userToBeUpdate, User user)
        {
            userToBeUpdate.NameSurname = user.NameSurname;
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<User>>GetAllUsers()
        {
            return await _unitOfWork.Users.GetAllAsync();
        }
    }
}


using GenericRepositoryExampla.Entities.Repositories;
using GenericRepositoryExampla.Entity.Model;
using GenericRepositoryExample.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExample.Business.Concrete
{
   public class SettingServices : ISettingServices
    {
        private IUnitOfWork _unitOfWork;
        public SettingServices(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<Setting> CreateSetting(Setting setting)
        {
            await _unitOfWork.Setting.AddAsync(setting);
            return setting;
        }

        public async Task DeleteSetting(Setting setting)
        {
            _unitOfWork.Setting.Remove(setting);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Setting>> GetAllSettings()
        {
            return await _unitOfWork.Setting.GetAllAsync();
        }

        public async Task<Setting> GetSettingById(int id)
        {
            return await _unitOfWork.Setting.GetByIdAsync(id);
        }

        public async Task UpdateSetting(Setting settingToBeUpdate, Setting setting)
        {
            settingToBeUpdate.Setting_Id = setting.Setting_Id;
            await _unitOfWork.CommitAsync();
        }
    }
}

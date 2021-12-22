
using GenericRepositoryExampla.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExample.Business.Abstract
{
   public interface ISettingServices
    {
        Task<IEnumerable<Setting>> GetAllSettings();
        Task<Setting> GetSettingById(int id);
        Task<Setting> CreateSetting(Setting suggestion);
        Task UpdateSetting(Setting settingToBeUpdate, Setting setting);
        Task DeleteSetting(Setting setting);
    }
}

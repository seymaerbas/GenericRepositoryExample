using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExampla.Entities.Repositories
{
   public interface IUnitOfWork :IDisposable
    {
        IUserRepository Users { get; }
        IProfileRepository Profiles { get;  }
        IContentRepository Contents { get; }
        ICategoryRepository Categories { get; }
        Task<int> CommitAsync();
    }
}

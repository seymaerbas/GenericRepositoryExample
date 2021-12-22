using GenericRepositoryExampla.Entity.Repositories;
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
        ICommentRepository Comment { get; }
        IFaqRepository Faq { get; }
        IMessageRepository Message { get; }
        IFolderRepository Folder { get; }
        ISuggestionRepository Suggestion { get; }
        ISettingRepository Setting { get; }
        Task<int> CommitAsync();
    }
}

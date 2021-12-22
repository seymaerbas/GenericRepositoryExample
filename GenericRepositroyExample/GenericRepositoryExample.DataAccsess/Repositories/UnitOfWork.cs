using GenericRepositoryExampla.DataAcces.Repositories;
using GenericRepositoryExampla.Entities.Repositories;
using GenericRepositoryExampla.Entity.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExample.DataAccsess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private GenericDbContext _context;
        private UserRepository _userRepository;
        private ProfileRepository _profileRepository;
        private ContentRepository _contentRepository;
        private CategoryRepository _categoryRepository;
        private CommentRepository _commentRepository;
        private FaqRepository _faqRepository;
        private MessageRepository _messageRepository;
        private FolderRepository _folderRepsitory;
        private SuggestionRepository _suggestionRepository;
        private SettingRepository _settingRepository;

        public UnitOfWork(GenericDbContext context) //constructer
        {
            this._context = context;
        }
        public IUserRepository Users => _userRepository = _userRepository ?? new UserRepository(_context);
        public IProfileRepository Profiles => _profileRepository = _profileRepository ?? new ProfileRepository(_context);

        public IContentRepository Contents => _contentRepository = _contentRepository ?? new ContentRepository(_context);

        public ICategoryRepository Categories => _categoryRepository = _categoryRepository ?? new CategoryRepository(_context);
        public ICommentRepository Comment => _commentRepository = _commentRepository ?? new CommentRepository(_context);

        public IFaqRepository Faq => _faqRepository = _faqRepository ?? new FaqRepository(_context);
        public IMessageRepository Message => _messageRepository = _messageRepository ?? new MessageRepository(_context);

        public IFolderRepository Folder => _folderRepsitory = _folderRepsitory ?? new FolderRepository(_context);

        public ISuggestionRepository Suggestion => _suggestionRepository = _suggestionRepository ?? new SuggestionRepository(_context);
        public ISettingRepository Setting => _settingRepository = _settingRepository ?? new SettingRepository(_context);
        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }
        //bir nesne ile işimiz bittikten sonra dispose etmemiz ramden silmemiz gerekir
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

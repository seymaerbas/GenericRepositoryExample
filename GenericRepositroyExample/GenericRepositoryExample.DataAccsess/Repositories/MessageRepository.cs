
using GenericRepositoryExampla.Entity.Model;
using GenericRepositoryExampla.Entity.Repositories;
using GenericRepositoryExample.DataAccsess;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRepositoryExampla.DataAcces.Repositories
{
    public class MessageRepository : Repository<Message>, IMessageRepository
    {
        public MessageRepository(GenericDbContext context) : base(context) { }
    }
}

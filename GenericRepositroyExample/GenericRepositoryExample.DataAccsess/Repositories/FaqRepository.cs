
using GenericRepositoryExampla.Entity.Model;
using GenericRepositoryExampla.Entity.Repositories;
using GenericRepositoryExample.DataAccsess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExampla.DataAcces.Repositories
{
    public class FaqRepository : Repository<Faq>, IFaqRepository
    {
        public FaqRepository(GenericDbContext context) : base(context) { }
        private GenericDbContext GenericDbContext
        {
            get { return Context as GenericDbContext; }
        }

        //public Task<IEnumerable<Faq>> GetAllWithFaqAsync()
        //{
        //    throw new NotImplementedException();
        //}
    }
}

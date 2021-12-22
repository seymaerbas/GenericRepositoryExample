
using GenericRepositoryExampla.Entity.Model;
using GenericRepositoryExampla.Entity.Repositories;
using GenericRepositoryExample.DataAccsess;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRepositoryExampla.DataAcces.Repositories
{
    public class SettingRepository : Repository<Setting>, ISettingRepository
    {
        public SettingRepository(GenericDbContext context) : base(context) { }
        private GenericDbContext GenericDbContext
        {
            get { return Context as GenericDbContext; }
        }
    }
}

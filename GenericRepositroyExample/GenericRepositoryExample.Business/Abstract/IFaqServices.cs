
using GenericRepositoryExampla.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExample.Business.Abstract
{
    public interface IFaqServices
    {
        Task<IEnumerable<Faq>> GetAllFaqs();
        Task<Faq> GetFaqById(int id);
        Task<Faq> CreateFaq(Faq faq);
        Task UpdateFaq(Faq faqToBeUpdate, Faq faq);
        Task DeleteFaq(Faq faq);
    }
}

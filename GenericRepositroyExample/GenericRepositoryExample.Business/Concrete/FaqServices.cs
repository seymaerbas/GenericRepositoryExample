
using GenericRepositoryExampla.Entities.Repositories;
using GenericRepositoryExampla.Entity.Model;
using GenericRepositoryExample.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExample.Business.Concrete
{
    public class FaqServices : IFaqServices
    {
        private IUnitOfWork _unitOfWork;
        public FaqServices(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<Faq> CreateFaq(Faq faq)
        {
            await _unitOfWork.Faq.AddAsync(faq);
            return faq;
        }

        public async Task DeleteFaq(Faq faq)
        {
            _unitOfWork.Faq.Remove(faq);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Faq>> GetAllFaqs()
        {
            return await _unitOfWork.Faq.GetAllAsync();
        }

        public async Task<Faq> GetFaqById(int id)
        {
            return await _unitOfWork.Faq.GetByIdAsync(id);
        }

        public async Task UpdateFaq(Faq faqToBeUpdate, Faq faq)
        {
            faqToBeUpdate.Question = faq.Question;
            await _unitOfWork.CommitAsync();
        }
    }
}

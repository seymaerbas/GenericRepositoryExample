using GenericRepositoryExampla.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExample.Business.Abstract
{
    public interface IContentServices
    {
        Task<IEnumerable<Content>> GetAllContent(); //tüm profilleri getir
        Task<Content> GetContentById(int id); //idsi ? olan profili getir
        Task<Content> CreateContent(Content content); //entity
        Task UpdateContent( Content content);
        Task DeleteContent(Content content);
       
    }
}

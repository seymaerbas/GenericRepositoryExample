using GenericRepositoryExampla.Api.Helpers;
using GenericRepositoryExampla.Entities.Model;
using GenericRepositoryExample.Business.Abstract;
using GenericRepositoryExample.DataAccsess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepositoryExampla.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentController : ControllerBase
    {
        //private IContentServices _contentServices;
        //private readonly GenericDbContext _context;
        //private readonly IConfiguration _configuration;
        //private readonly GenericHelperMethods _genericHelperMethods;


        //public ContentController(GenericDbContext context, IConfiguration configuration, GenericHelperMethods genericHelperMethods, IContentServices contentServices)
        //{
        //    _context = context;
        //    _configuration = configuration;
        //    _genericHelperMethods = genericHelperMethods;
        //    this._contentServices = contentServices;
        //}
        private IContentServices _contentServices;

        public ContentController(IContentServices contentServices)
        {
            _contentServices = contentServices;
        }
        [HttpGet("GetAll")]
        public async Task<Response<IEnumerable<Content>>> GetAll()
        {
            var contents = await _contentServices.GetAllContent();
            if (!contents.Any())
            {
                return new Response<IEnumerable<Content>>().NoContent();
            }
            //List olsaydı .count parantez yazmamız dpğru değil.
            return new Response<IEnumerable<Content>>().Ok(contents.Count(), contents);
        }

        //[HttpPost("[action]")]
        //public async Task<Content> Create(Content content)
        //{
        //    await _contentServices.CreateContent(content);
        //    return content;
        //}

        [HttpPost("GetAllContents")]
        public async Task<Response<IEnumerable<Content>>> GetAllContents()
        {
            try
            {
                var draw = Request.Form["draw"].FirstOrDefault();
                var start = Request.Form["start"].FirstOrDefault();
                var length = Request.Form["length"].FirstOrDefault();
                var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
                var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
                var searchValue = Request.Form["search[value]"].FirstOrDefault();
                int pageSize = length != null ? Convert.ToInt32(length) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;
                int recordsTotal = 0;
                //var companies = await _companyServices.GetAllCompanies();
                var customerData = (from tempcustomer in await _contentServices.GetAllContent() select tempcustomer);
                if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
                {
                    customerData = customerData.OrderBy(s => s.Title == (sortColumn + " " + sortColumnDirection));
                }
                if (!string.IsNullOrEmpty(searchValue))
                {
                    customerData = customerData.Where(m => m.Content_Id.ToString().Contains(searchValue)
                                                || m.Title.Contains(searchValue)
                                                || m.Description.Contains(searchValue)
                                                || m.Detail.Contains(searchValue));
                }
                recordsTotal = customerData.Count();
                var data = customerData.Skip(skip).Take(pageSize).ToList();
                var jsonData = new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data };
                //return Ok(jsonData);
                return new Response<IEnumerable<Content>>().Ok(customerData.Count(), customerData);
            }
            catch (Exception ex)
            {
                throw;
            }


        }

        //[HttpPost("GetAllContents")]
        //public async Task<Response<IEnumerable<Content>>> GetAllContents()
        //{
        //    try
        //    {
        //        var draw = Request.Form["draw"].FirstOrDefault();
        //        var start = Request.Form["start"].FirstOrDefault();
        //        var length = Request.Form["length"].FirstOrDefault();
        //        var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
        //        var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
        //        var searchValue = Request.Form["search[value]"].FirstOrDefault();
        //        int pageSize = length != null ? Convert.ToInt32(length) : 0;
        //        int skip = start != null ? Convert.ToInt32(start) : 0;
        //        int recordsTotal = 0;
        //        var customerData = (from tempcustomer in await _contentServices.GetAllContent() select tempcustomer);
        //        if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
        //        {
        //            customerData = customerData.OrderBy(s => s.Title == (sortColumn + "" + sortColumnDirection));
        //        }
        //        if (!string.IsNullOrEmpty(searchValue))
        //        {
        //            customerData = customerData.Where(m => m.Title.Contains(searchValue)
        //                                                || m.Description.Contains(searchValue)
        //                                                || m.Detail.Contains(searchValue));
        //        }

        //        recordsTotal = customerData.Count();
        //        var data = customerData.Skip(skip).Take(pageSize).ToList(); //skip sonraki sayfayı verir take ise pagesize kadar eleman verir
        //        var jsonData = new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data };
        //        // return Ok(jsonData);
        //        return new Response<IEnumerable<Content>>().Ok(recordsTotal, data); //data yerine customerdata olsaydı orjinal datanın hepsi dönerdi
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}
        [HttpPost("[action]")]
        public async Task<Response<Content>> Create(Content content)
        {

            try
            {
                if (content.Content_Id == 0)
                    await _contentServices.CreateContent(content);
                else await _contentServices.UpdateContent(content);
                return new Response<Content>().Ok(1, content);
            }
            catch (Exception ex)
            {
                return new Response<Content>().Error(1, content, ex.ToString());
            }
        }

        [HttpPost("[action]/{id}")]
        public async void Delete(int id)
        {
            if (id != 0)
            {
                var deleteData = await _contentServices.GetContentById(id);
                await _contentServices.DeleteContent(deleteData);
            }

        }
        [HttpPost]
        [Route("[action]")]
        public IActionResult Post([FromBody] Content content)
        {
            var createContent = _contentServices.CreateContent(content);
            return Ok(createContent);
        }
        //[HttpDelete("{id}")]
        //public IActionResult Delete(Content content)
        //{
        //    _contentServices.DeleteContent(content);
        //    return Ok("Content Deleted");
        //}

        
      
    }
}
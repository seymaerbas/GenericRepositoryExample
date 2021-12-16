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
        private IContentServices _contentServices;
        private readonly GenericDbContext _context;
        private readonly IConfiguration _configuration;
        private readonly GenericHelperMethods _genericHelperMethods;
       

        public ContentController(GenericDbContext context, IConfiguration configuration, GenericHelperMethods genericHelperMethods, IContentServices contentServices)
        {
            _context = context;
            _configuration = configuration;
            _genericHelperMethods = genericHelperMethods;
            this._contentServices = contentServices;
        }
        [HttpPost("[action]")]
        public async Task<bool> Create([FromBody] Content content)
        {
            _context.Contents.Add(content);
            await _context.SaveChangesAsync();
            return true;
        }
        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<Content>>> GetAllContents()
        {
            var content = await _contentServices.GetAllContent();
            return Ok(content);
        }
        //[HttpPost("[action]")]
        //public async Task<Content> Create(Content content)
        //{
        //    await _contentServices.CreateContent(content);
        //    return content;
        //}
    }
}

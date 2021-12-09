using GenericRepositoryExampla.Entities.Model;
using GenericRepositoryExample.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public ContentController(IContentServices contentServices)
        {
            _contentServices = contentServices;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Content>>> GetAllContents()
        {
            var content = await _contentServices.GetAllContent();
            return Ok(content);
        }
    }
}

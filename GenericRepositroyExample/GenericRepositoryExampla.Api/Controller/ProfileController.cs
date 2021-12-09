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
    public class ProfileController : ControllerBase
    {
        private IProfileServices _profileServices;
        public ProfileController(IProfileServices profileServices)
        {
            _profileServices = profileServices;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Profile>>> GetAllProfile()
        {
            var user = await _profileServices.GetAllProfiles();
            return Ok(user);
        }
    }
}

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
    public class UserController : ControllerBase
    {
        //private IUserServices _userServices;
        //public UserController(IUserServices userServices)
        //{
        //    _userServices = userServices;
        //}

        private IUserServices _userServices;
        private readonly GenericDbContext _context;
        private readonly IConfiguration _configuration;
        private readonly GenericHelperMethods _genericHelperMethods;


        public UserController(GenericDbContext context, IConfiguration configuration, GenericHelperMethods genericHelperMethods, IUserServices userServices)
        {
            _context = context;
            _configuration = configuration;
            _genericHelperMethods = genericHelperMethods;
            this._userServices = userServices;
        }
        [HttpPost("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            //var user = await _userServices.GetAllUsers();
            //return Ok(user);
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
                var userData = (from tempcustomer in await _userServices.GetAllUsers() select tempcustomer);
                if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
                {
                    userData = userData.OrderBy(s => s.NameSurname == (sortColumn + "" + sortColumnDirection));
                }
                if (!string.IsNullOrEmpty(searchValue))
                {
                    userData = userData.Where(m => m.NameSurname.Contains(searchValue)
                                                || m.Password.Contains(searchValue)
                                                || m.IsActive.ToString().Contains(searchValue)
                                                || m.Email.Contains(searchValue));

                }
                recordsTotal = userData.Count();
                var data = userData.Skip(skip).Take(pageSize).ToList();
                var jsonData = new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data };
                return Ok(jsonData);
                //return new Response<IEnumerable<User>>().Ok(recordsTotal, data);

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        [HttpPost("[action]/{id}")]
        public async void Delete(int id)
        {
            if (id != 0)
            {
                var deleteData = await _userServices.GetUserById(id);
                await _userServices.DeleteUser(deleteData);
            }

        }
    }
}

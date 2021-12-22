using GenericRepositoryExampla.Api.Helpers;
using GenericRepositoryExampla.Api.Pages.Helpers;
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
    public class CategoryController : ControllerBase
    {
        private ICategoryServices _categoryServices;
        private readonly GenericDbContext _context;
        private readonly IConfiguration _configuration;
        private readonly GenericHelperMethods _genericHelperMethods;


        public CategoryController(GenericDbContext context, IConfiguration configuration, GenericHelperMethods genericHelperMethods, ICategoryServices categoryServices)
        {
            _context = context;
            _configuration = configuration;
            _genericHelperMethods = genericHelperMethods;
            this._categoryServices = categoryServices;
        }
        [HttpPost("[action]")]
        public async Task<bool> Create([FromBody] Category category)
        {
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
            return true;
        }
        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<Category>>> GetAllCategories()
        {
            var category = await _categoryServices.GetAllCategory();
            return Ok(category);
        }
        
        //[HttpGet("GetAll")]
        //public async Task<Response<IEnumerable<Category>>> GetAll()

        //{
        //    var products = await _categoryServices.GetAllCategory();

        //    return new Response<IEnumerable<Category>>().Ok(products);
        //}
        [HttpGet("GetAll")]
        public async Task<Response<IEnumerable<Category>>> GetAll()

        {
            var Category = await _categoryServices.GetAllCategory();
            if (!Category.Any())
            {
                return new Response<IEnumerable<Category>>().NoContent();
            }
            //List olsaydı .count parantez yazmamız dpğru değil.
            return new Response<IEnumerable<Category>>().Ok(Category.Count(), Category);
        }
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    if (await _categoryServices.GetCategoryById(id) != null)
        //    {
        //        _categoryServices.DeleteCategory(id);
        //        return Ok("Deleted category");
        //    }

        //    return NotFound();
        //}
        //public CategoryController(ICategoryServices categoryServices)
        //{
        //    this._categoryServices = categoryServices;
        //}
        //[HttpGet("[action]")]
        //public async Task<ActionResult<IEnumerable<Category>>> GetAllCategories()
        //{
        //    var category = await _categoryServices.GetAllCategory();
        //    return Ok(category);
        //}
        //[HttpPost("[action]")]
        //public async Task<Category> Create(Category category)
        //{
        //    await _categoryServices.CreateCategory(category);
        //    return category;
        //}
    }
}

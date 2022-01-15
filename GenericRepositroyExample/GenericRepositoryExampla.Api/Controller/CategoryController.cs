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
using System.Linq.Dynamic.Core;
using System.Net;
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
        //[HttpGet("[action]")]
        //public async Task<ActionResult<IEnumerable<Category>>> GetAllCategories()
        //{
        //    var category = await _categoryServices.GetAllCategory();
        //    return Ok(category);
        //}

        [HttpPost("GetAllCategory")]
        public async Task<IActionResult> GetAllCategory()
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
                var category = await _categoryServices.GetAllCategory();
                var categoryData = (from tempcustomer in category select tempcustomer);
                //var categoryData = (from tempcustomer in await _categoryServices.GetAllCategory() select tempcustomer);
                if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
                {
                    categoryData = categoryData.OrderBy(s => s.Title == (sortColumn + "" + sortColumnDirection));
                }
                if (!string.IsNullOrEmpty(searchValue))
                {
                    categoryData = categoryData.Where(m => m.Title.Contains(searchValue));
                                                       

                }

                recordsTotal = categoryData.Count();
                var data = categoryData.Skip(skip).Take(pageSize).ToList();//skip sonraki sayfayı verir take ise pagesize kadar eleman verir
                var jsonData = new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data };
                return Ok(jsonData);
                // return new Response<IEnumerable<Category>>().Ok(recordsTotal, data); //data yerine customerdata olsaydı orjinal datanın hepsi dönerdi
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpGet("GetAll")]
        public async Task<Response<IEnumerable<Category>>> GetAll()

        {
            var products = await _categoryServices.GetAllCategory();

            return new Response<IEnumerable<Category>>().Ok(products);
        }
        //[HttpGet("GetAll")]
        //public async Task<Response<IEnumerable<Category>>> GetAll()

        //{
        //    var Category = await _categoryServices.GetAllCategory();
        //    if (!Category.Any())
        //    {
        //        return new Response<IEnumerable<Category>>().NoContent();
        //    }
        //    //List olsaydı .count parantez yazmamız dpğru değil.
        //    return new Response<IEnumerable<Category>>().Ok(Category.Count(), Category);
        //}
        [HttpPost("[action]/{id}")]
        public async void Delete(int id)
        {
            if (id != 0)
            {
                var deleteData = await _categoryServices.GetCategoryById(id);
                await _categoryServices.DeleteCategory(deleteData);
            }

        }

        //[HttpPost]
        //public ActionResult DeleteCategory(int id)
        //{
        //    var deleteCategory = _context.Categories.Where(x => x.Category_Id == id).FirstOrDefault();
        //    if (deleteCategory == null)
        //    {
        //        return new JsonResult(HttpStatusCode.BadRequest);
        //    }
        //    _context.Categories.Remove(deleteCategory);
        //    _context.SaveChanges();
        //    return null;
        //}

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
        //private ICategoryServices _categoryServices;

        //public CategoryController(ICategoryServices categoryServices)
        //{
        //    _categoryServices = categoryServices;
        //}
        //[HttpGet("GetAll")]
        //public async Task<Response<IEnumerable<Category>>> GetAll()
        //{
        //    var category = await _categoryServices.GetAllCategory();
        //    if (!category.Any())
        //    {
        //        return new Response<IEnumerable<Category>>().NoContent();
        //    }
        //    //List olsaydı .count parantez yazmamız dpğru değil.
        //    return new Response<IEnumerable<Category>>().Ok(category.Count(), category);
        //}


        //[HttpPost]
        //[Route("[action]")]
        //public IActionResult Post([FromBody] Category category)
        //{
        //    var createCategory = _categoryServices.CreateCategory(category);
        //    return Ok(createCategory);
        //}
        //[HttpDelete("{id}")]
        //public IActionResult Delete(Category category)
        //{
        //    _categoryServices.DeleteCategory(category);
        //    return Ok("Category Deleted");
        //}

        //[HttpPut]
        //public IActionResult UpdateCategory([FromBody] Category category)
        //{
        //    _categoryServices.UpdateCategory(category, category);
        //    return Ok();
        //}
    }

}


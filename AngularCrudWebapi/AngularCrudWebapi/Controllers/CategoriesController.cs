using AngularCrudWebapi.Model.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AngularCrudWebapi.Model.Domain;
using Microsoft.EntityFrameworkCore;
using AngularCrudWebapi.Model.Data;
using AngularCrudWebapi.Model.Repository.Interface;

namespace AngularCrudWebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto request)
        {   

            // data access from UI to Dto
            var Category = new Category
            {
                Name = request.Name,
                UrlHandle = request.UrlHandle
            };
            await categoryRepository.InsertCategory(Category);
            
           
            //dto to Domain
            var response = new Categorydto
            {
                Id = Category.Id,
                Name = Category.Name,
                UrlHandle = Category.UrlHandle
            };
            return Ok(response);
        }
    }
}

using AngularCrudWebapi.Model.Domain;
using AngularCrudWebapi.Model.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using AngularCrudWebapi.Model.Data;
using Microsoft.EntityFrameworkCore;

namespace AngularCrudWebapi.Model.Repository.InterfaceImplementation
{
    public class CategoryRepository : ICategoryRepository
    {

        private readonly AplicationDbContext dbContext;
        public CategoryRepository(AplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Category> InsertCategory(Category category)
        {
            await dbContext.tblCategories.AddAsync(category);
            await dbContext.SaveChangesAsync();

            return category;
        }
    }
}

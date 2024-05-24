using Microsoft.AspNetCore.Mvc;
using AngularCrudWebapi.Model.Domain;
namespace AngularCrudWebapi.Model.Repository.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> InsertCategory(Category category);
    }
}

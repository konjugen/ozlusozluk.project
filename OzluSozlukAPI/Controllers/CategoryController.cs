using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData;
using System.Web.Http.OData.Query;
using System.Web.WebPages;
using Api.DAL.DTO;
using Api.DAL.Repository;
using Api.DAL.Service;
using Api.Data;

namespace OzluSozlukAPI.Controllers
{
    public class CategoryController : ApiController
    {
        public List<CategoryDto> GetAll()
        {
            var ds = new DataService();
            var result = ds.GetCategories();
            return result;
        }

        public List<CategoryDto> GetCategoryById(int categoryId)
        {
            var ds = new DataService();
            var result = ds.GetCategoriesById(categoryId);
            return result;
        }

        //public IQueryable<Category> GetCategories()
        //{
        //    var db = new ContentDBEntities();

        //    return db.Categories.AsQueryable();
        //} 
    }
}

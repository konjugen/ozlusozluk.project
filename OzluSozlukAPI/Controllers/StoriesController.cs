using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Api.DAL.DTO;
using Api.DAL.Repository;
using Api.DAL.Service;
using Api.Data;

namespace OzluSozlukAPI.Controllers
{
    public class StoriesController : ApiController
    {
        public List<StoriesDto> GetAll()
        {
            var ds = new DataService();
            var result = ds.GetStories();
            return result;
        }

        //public IQueryable<Stories> GetStories()
        //{
        //    var db = new ContentDBEntities();

        //    return db.Stories.AsQueryable();
        //}
    }
}
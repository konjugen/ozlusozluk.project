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
    public class WriterController : ApiController
    {
        public List<WriterDto> GetAll()
        {
            var ds = new DataService();
            var result = ds.GetWriter();
            return result;
        }

        //public IQueryable<Writer> GetWriter()
        //{
        //    var db = new ContentDBEntities();

        //    return db.Writer.AsQueryable();
        //}
    }
}
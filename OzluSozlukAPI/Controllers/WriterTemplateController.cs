using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Api.DAL.DTO;
using Api.DAL.Service;
using Api.Data;

namespace OzluSozlukAPI.Controllers
{
    public class WriterTemplateController : ApiController
    {

        public List<WriterTemplateDto> GetAll()
        {
            var ds = new DataService();
            var result = ds.GetWriterTemplate();
            return result;
        }
        //public IQueryable<WriterTemplate> GetWriterTemplate()
        //{
        //    var db = new ContentDBEntities();

        //    return db.WriterTemplate.AsQueryable();
        //}
    }
}
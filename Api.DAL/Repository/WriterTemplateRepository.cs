using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Data;

namespace Api.DAL.Repository
{
    public class WriterTemplateRepository
    {
        public List<WriterTemplate> GetAll()
        {
            using (var entites = new ContentDBEntities())
            {
                var writerTemplate = entites.WriterTemplate.Where(p => p.IsActive).ToList();
                return writerTemplate;
            }
        }
    }
}

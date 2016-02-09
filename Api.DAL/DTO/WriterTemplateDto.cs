using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.DAL.DTO
{
    public class WriterTemplateDto
    {
        public int PKTemplateId { get; set; }
        public int FKWriterId { get; set; }
        public byte[] TemplateBody { get; set; }
        public bool IsActive { get; set; }
    }
}

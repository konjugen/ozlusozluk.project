using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.DAL.DTO
{
    public class WriterDto
    {
        public int PKWriterId { get; set; }
        public string WriterName { get; set; }
        public bool Daily { get; set; }
        public bool IsActive { get; set; }
    }
}

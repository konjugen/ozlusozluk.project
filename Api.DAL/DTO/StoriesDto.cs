using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.DAL.DTO
{
    public class StoriesDto
    {
        public int PKStoryId { get; set; }
        public int FKCategoryId { get; set; }
        public int FKWriterId { get; set; }
        public string Body { get; set; }
        public bool IsActive { get; set; }
 
    }
}

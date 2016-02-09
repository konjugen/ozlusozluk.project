using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Api.Contract.DTO
{

    [DataContract]
    public class Request
    {
        [DataMember]
        public int CategoryId { get; set; }
    }
}

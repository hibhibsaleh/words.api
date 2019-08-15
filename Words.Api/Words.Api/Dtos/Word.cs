using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Words.Api.Dto
{
    // Dto = Data Tranfser Object
    // Thinned out version of entity
    // Specific data to return from entity per request
    public class GetWordDto
    {
        public int Id { get; set; }
        public string WordName { get; set; }
    }
}

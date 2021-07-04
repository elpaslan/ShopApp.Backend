using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class BrandDetailDto:IDto
    {
        public long BrandId { get; set; }
        public string BrandName { get; set; }
        public List<string> Images { get; set; }
    }
}

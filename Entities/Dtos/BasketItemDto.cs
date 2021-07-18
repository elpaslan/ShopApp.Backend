using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class BasketItemDto
    {
        public long Id { get; set; }        
        public string ProductName { get; set; }        
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string PictureUrl { get; set; }
        public string Brand { get; set; }
        //public List<string> Images { get; set; }
        public DateTime CreatedDate { get; set; }
      
    }
}

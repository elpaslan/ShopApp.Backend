﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product:IEntity
    {
        public int Id { get; set; }       
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public int DiscountRate { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Active { get; set; }

        public int CategoryId { get; set; }
        public int BrandId { get; set; }
    }
}

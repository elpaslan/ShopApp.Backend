﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class BrandImages:IEntity
    {
        public int Id { get; set; }
        public long BrandId { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date { get; set; }

        public BrandImages()
        {
            Date = DateTime.Now;
        }
    }
}

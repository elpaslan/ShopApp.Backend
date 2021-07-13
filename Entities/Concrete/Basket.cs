using Core.Entities;
using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Basket : IEntity
    {
        public Basket()
        {
                
        }
        public Basket(string id)
        {
            Id = id;
        }

        public string Id { get; set; }
        public List<BasketItem> BasketItems { get; set; } = new List<BasketItem>();
        public DateTime CreateDate { get; set; }
    }
}

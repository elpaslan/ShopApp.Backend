using Business.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
        private IBasketService _basketService;

        public BasketsController(IBasketService basketService)
        {
            _basketService = basketService;
        }

        [HttpGet]
        public async Task<ActionResult<Basket>> GetBasketById(string id)
        {
            var basket = await _basketService.GetBasketAsync(id);
            return Ok(basket ?? new Basket(id));
        }

        [HttpPost]
        public async Task<ActionResult<Basket>> UpdateBasket(Basket basket)
        {
            if (basket.Id == null)
            {
                var newGuidValue = Guid.NewGuid();
                basket.Id = newGuidValue.ToString();
            }
            var updateBasket = await _basketService.UpdateBasketAsync(basket);
            return Ok(updateBasket);
        }

        

        [HttpDelete] 
        public async Task DeleteBasketAsync(string id) 
        {
            await _basketService.DeleteBasketAsync(id);
        }


    }
}

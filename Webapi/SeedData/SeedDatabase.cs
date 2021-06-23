using DataAccess.Concrete.EfCore.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ShopApp.Core.Webapi.SeedData
{
    public class SeedDatabase
    {
      
        public static async Task SeedAsync(ShopContext context)
        {
            
            //if (!context.Brands.Any())
            //{
            //    var brandsdata = File.ReadAllText("SeedData/brands.json");
            //    var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsdata);

            //    foreach( var item in brands)
            //    {
            //        context.ProductBrands.Add(item);
            //    }
            //    await context.SaveChangesAsync();
            //}

            //if (!context.Categories.Any())
            //{
            //    var typesdata = File.ReadAllText("SeedData/types.json");
            //    var types = JsonSerializer.Deserialize<List<ProductType>>(typesdata);

            //    foreach (var item in types)
            //    {
            //        context.ProductTypes.Add(item);
            //    }
            //    await context.SaveChangesAsync();
            //}

            if (!context.Products.Any())
            {
                var productsdata = File.ReadAllText("SeedData/products.json");
                var products = JsonSerializer.Deserialize<List<Product>>(productsdata);

                foreach (var item in products)
                {
                    context.Products.Add(item);
                }
                await context.SaveChangesAsync();
            }
        }
    }
}

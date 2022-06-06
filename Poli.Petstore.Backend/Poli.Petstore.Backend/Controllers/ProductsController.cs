using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Poli.Petstore.Backend.Models;

namespace Poli.Petstore.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            List<Product> productList = new List<Product>() {
                new Product()
                {
                    Id = 1,
                    Name = "Casa mascotas RIMAX",
                    Description = "Casa para perros de razas mediana y grande marca Rimax",
                    Price = 290000,
                    Discount = 10,
                    ThumbnailUrl = "img/casa-mascotas-perros-rimax.jpg",
                },
                 new Product()
                {
                    Id = 2,
                    Name = "Casa raza grande",
                    Description = "Casa para perros de raza grande",
                    Price = 320000,
                    Discount = 5,
                    ThumbnailUrl = "img/casas-perros-medianos.png",
                },
                  new Product()
                {
                    Id = 3,
                    Name = "Casa dos niveles",
                    Description = "Casa de madera dos niveles. Raza pequeña",
                    Price = 450000,
                    Discount = 5,
                    ThumbnailUrl = "img/casa-mascotas-perros-niveles.jpg",
                },
                   new Product()
                {
                    Id = 4,
                    Name = "Casa gato",
                    Description = "Casa para perros de razas mediana y grande marca Rimax",
                    Price = 220000,
                    Discount = 5,
                    ThumbnailUrl = "img/casa-gato1.jpg",
                },
                    new Product()
                {
                    Id = 5,
                    Name = "Casa gimnasio",
                    Description = "Casa para perros de razas mediana y grande marca Rimax",
                    Price = 290000,
                    Discount = 10,
                    ThumbnailUrl = "img/casa-mascotas-perros-rimax.jpg",
                }
            };
            return productList;
        }
    }
}

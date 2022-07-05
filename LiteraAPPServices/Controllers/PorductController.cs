using LiteraAPPServices.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiteraAPPServices.Controllers
{
    [ApiController]
    [Route("/api/product")]
    public class PorductController : Controller
    {
        private readonly ProductService productService;

        public PorductController( ProductService _productService) 
        {
            productService = _productService;

        }
        
        [HttpGet]
        public IActionResult GetProduct()
        {
           
            
            return Ok(productService.GetProducts());
        }
    }
}

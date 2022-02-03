using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Packaging_And_Delivery.Models;
using Packaging_And_Delivery.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Packaging_And_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackagingAndDeliveryController : Controller
    {
        /*public IActionResult Index()
        {
            return View();
        }*/

        /*private static IConfiguration _config;
        public PackagingAndDeliveryController(IConfiguration config)
        {
            _config = config;
        }*/

        private readonly IPackagingAndDeliveryChargeServices myService;
        public PackagingAndDeliveryController(IPackagingAndDeliveryChargeServices service)
        {
            myService = service;
        }

        [HttpGet]
        public IActionResult PackagingAndDelivery(PackagingAndDeliveryInputs input)
        {

            int price = myService.CalculateCharge(input);
            if(price == 0)
            {
                return BadRequest("Request item is not available");
            }
            return Ok(price);
        }
    }
}

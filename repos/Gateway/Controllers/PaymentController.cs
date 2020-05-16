using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Business.Service;
using Business.Model;
using Microsoft.AspNetCore.Authorization;

namespace Gateway.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class PaymentController : ControllerBase
    {

        static List<PaymentModel> pm = new List<PaymentModel>();
        PaymentService paymentService;
        public PaymentController()
        {
            paymentService = new PaymentService();
        }
        [HttpPost]
        public IActionResult Validate([FromBody] PaymentModel pay)
        {
            var token = paymentService.Validate(pay);

            if (token)
            {
                pm.Add(pay);
            }
                return Ok(token);

        }
        [HttpGet("list")]
        public IActionResult list()
        {
            return Ok(pm);
        }
    }
}
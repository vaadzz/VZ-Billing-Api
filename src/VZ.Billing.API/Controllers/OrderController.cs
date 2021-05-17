using Microsoft.AspNetCore.Mvc;
using VZ.Billing.BusinessLayer.Services;
using VZ.Billing.Entities.Models;

namespace VZ.Billing.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IBillingService billingService;
        public OrderController(IBillingService billingService)
        {
            this.billingService = billingService;
        }

        [HttpGet]
        public IPaymentResult ProcessOrder([FromQuery]  Order order)
        {
            var paymentResult = billingService.Process(order);

            return paymentResult;
        }
    }
}

using System.Collections.Generic;
using VZ.Billing.BusinessLayer.Implementation.Payment;
using VZ.Billing.Entities.Enums;
using VZ.Billing.Entities.Models;

namespace VZ.Billing.BusinessLayer.Services.Implementation
{
    public class BillingService : IBillingService
    {
        private readonly Dictionary<PaymentGateway, IPaymentService> paymentServices;
        public BillingService(Dictionary<PaymentGateway, IPaymentService> paymentServices)
        {
            this.paymentServices = paymentServices;
        }

        public IPaymentResult Process(Order order)
        {
            var result = new PaymentResult();
            var hasService = paymentServices.ContainsKey(order.PaymentGateway);

            if (hasService)
            {
                var service = paymentServices[order.PaymentGateway];
                result.Receipt = service.Process(order);
                return result;
            }

            result.ErrorMessage = "Unsupported payment gateway";
            return result;
        }
    }
}

using VZ.Billing.Entities.Models;

namespace VZ.Billing.BusinessLayer.Services.Implementation.Payment
{
    public class PaymentService_C : IPaymentService
    {
        public Receipt Process(Order order)
        {
            return new Receipt()
            {
                Details = "Order was processed by PaymentService_C"
            };
        }
    }
}

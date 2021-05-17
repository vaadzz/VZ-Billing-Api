using VZ.Billing.BusinessLayer.Services;
using VZ.Billing.Entities.Models;

namespace VZ.Billing.BusinessLayer.Implementation.Payment
{
    public class PaymentResult : IPaymentResult
    {
        public Receipt Receipt { get; set ; }
        public string ErrorMessage { get; set; }
    }
}

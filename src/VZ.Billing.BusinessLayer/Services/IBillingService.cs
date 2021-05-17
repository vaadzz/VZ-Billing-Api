using VZ.Billing.Entities.Models;

namespace VZ.Billing.BusinessLayer.Services
{
    public interface IBillingService
    {
        IPaymentResult Process(Order order);
    }
}

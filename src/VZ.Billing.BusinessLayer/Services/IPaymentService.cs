using VZ.Billing.Entities.Models;

namespace VZ.Billing.BusinessLayer.Services
{
    public interface IPaymentService
    {
        Receipt Process(Order order);
    }
}

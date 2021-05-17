using VZ.Billing.Entities.Models;

namespace VZ.Billing.BusinessLayer.Services
{
    public interface IPaymentResult
    {
        Receipt Receipt { get; set; }
        string ErrorMessage { get; set; }
    }
}

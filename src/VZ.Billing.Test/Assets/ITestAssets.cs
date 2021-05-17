using System;
using System.Collections.Generic;
using System.Text;
using VZ.Billing.BusinessLayer.Services;
using VZ.Billing.Entities.Models;

namespace VZ.Billing.Test.Assets
{
    public interface ITestAssets
    {
        Order GetFineOrderForService_A();
        Order GetFineOrderForService_B();
        Order GetFineOrderForService_C();
        Order GetOrderWithWrongGateway();
        IPaymentResult GetPaymentResultForPaymentService_A();
        IPaymentResult GetPaymentResultForPaymentService_B();
        IPaymentResult GetPaymentResultForPaymentService_C();
        IPaymentResult GetPaymentResultWithError();
        Receipt GetReceiptForService_A();
        Receipt GetReceiptForService_B();
        Receipt GetReceiptForService_C();

    }
}

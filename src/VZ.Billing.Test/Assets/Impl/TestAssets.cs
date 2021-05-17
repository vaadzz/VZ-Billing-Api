using VZ.Billing.BusinessLayer.Implementation.Payment;
using VZ.Billing.BusinessLayer.Services;
using VZ.Billing.Entities.Enums;
using VZ.Billing.Entities.Models;

namespace VZ.Billing.Test.Assets.Impl
{
    public class TestAssets : ITestAssets
    {
        public IPaymentResult GetPaymentResultForPaymentService_A()
        {
            return new PaymentResult { Receipt = GetReceiptForService_A() };
        }

        public IPaymentResult GetPaymentResultForPaymentService_B()
        {
            return new PaymentResult { Receipt = GetReceiptForService_B() };
        }

        public IPaymentResult GetPaymentResultForPaymentService_C()
        {
            return new PaymentResult { Receipt = GetReceiptForService_C() };
        }

        public Receipt GetReceiptForService_A()
        {
            return new Receipt() { Details = "Order was processed by PaymentService_A" };
        }

        public Receipt GetReceiptForService_B()
        {
            return new Receipt() { Details = "Order was processed by PaymentService_B" };
        }

        public Receipt GetReceiptForService_C()
        {
            return new Receipt() { Details = "Order was processed by PaymentService_C" };
        }

        public IPaymentResult GetPaymentResultWithError()
        {
            return new PaymentResult() { ErrorMessage = "Unsupported payment gateway" };
        }

        public Order GetFineOrderForService_A()
        {
            return new Order()
            {
                Number = 1,
                PayableAmount = 100,
                Userid = 1234,
                PaymentGateway = PaymentGateway.PaymentGateway_A
            };
        }

        public Order GetFineOrderForService_B()
        {
            return new Order()
            {
                Number = 1,
                PayableAmount = 100,
                Userid = 1234,
                PaymentGateway = PaymentGateway.PaymentGateway_B
            };
        }

        public Order GetFineOrderForService_C()
        {
            return new Order()
            {
                Number = 1,
                PayableAmount = 100,
                Userid = 1234,
                PaymentGateway = PaymentGateway.PaymentGateway_C
            };
        }

        public Order GetOrderWithWrongGateway()
        {
            return new Order()
            {
                Number = 1,
                PayableAmount = 100,
                Userid = 1234,
                PaymentGateway = (PaymentGateway)5
            };
        }
    }
}

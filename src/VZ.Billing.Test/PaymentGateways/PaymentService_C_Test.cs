using VZ.Billing.BusinessLayer.Services.Implementation.Payment;
using VZ.Billing.Test.Assets;
using Xunit;

namespace VZ.Billing.Test.PaymentGateways
{
    public class PaymentService_C_Test
    {
        private readonly ITestAssets testAsset;
        public PaymentService_C_Test(ITestAssets testAsset)
        {
            this.testAsset = testAsset;
        }

        [Fact]
        public void Process_Order_ReturnsReceipt()
        {
            var service = new PaymentService_C();
            var order = testAsset.GetFineOrderForService_B();
            var actual = service.Process(order);
            var expected = testAsset.GetReceiptForService_C();

            Assert.Equal(expected.Details, actual.Details);
        }
    }
}

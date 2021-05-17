using VZ.Billing.BusinessLayer.Services.Implementation.Payment;
using VZ.Billing.Test.Assets;
using Xunit;

namespace VZ.Billing.Test.PaymentGateways
{
    public class PaymentService_A_Test
    {
        private readonly ITestAssets testAsset;
        public PaymentService_A_Test(ITestAssets testAsset)
        {
            this.testAsset = testAsset;
        }

        [Fact]
        public void Process_Order_ReturnsReceipt()
        {
            var service = new PaymentService_A();
            var order = testAsset.GetFineOrderForService_A();
            var actual = service.Process(order);
            var expected = testAsset.GetReceiptForService_A();

            Assert.Equal(expected.Details, actual.Details);
        }
    }
}
   

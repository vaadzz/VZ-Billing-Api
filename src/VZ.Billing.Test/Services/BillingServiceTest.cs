using VZ.Billing.BusinessLayer.Services;
using VZ.Billing.Test.Assets;
using Xunit;

namespace VZ.Billing.Test.Services
{
    public class BillingServiceTest
    {
        private readonly IBillingService billingService;
        private readonly ITestAssets testAsset;

        public BillingServiceTest(IBillingService billingService, ITestAssets testAsset)
        {
            this.billingService = billingService;
            this.testAsset = testAsset;
        }

        [Fact]
        public void Process_FineOrder_ReturnsPaymentWithReceipt()
        {
            var order = testAsset.GetFineOrderForService_A();
            var actual = billingService.Process(order);
            var expected = testAsset.GetPaymentResultForPaymentService_A();

            Assert.Equal(expected.Receipt.Details, actual.Receipt.Details);
        }

        [Fact]
        public void Process_BadOrder_ReturnsPaymentWithErrorMessage()
        {
            var order = testAsset.GetOrderWithWrongGateway();
            var actual = billingService.Process(order);
            var expected = testAsset.GetPaymentResultWithError();

            Assert.Equal(expected.ErrorMessage, actual.ErrorMessage);
        }
    }
}

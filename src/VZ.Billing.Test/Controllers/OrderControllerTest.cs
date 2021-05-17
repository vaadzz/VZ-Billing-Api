using VZ.Billing.API.Controllers;
using VZ.Billing.BusinessLayer.Services;
using VZ.Billing.Test.Assets;
using Xunit;

namespace VZ.Billing.Test.Controllers
{
    public class OrderControllerTest
    {
        private readonly IBillingService billingService;
        private readonly ITestAssets testAsset;
        private readonly OrderController controller;

        public OrderControllerTest(IBillingService billingService, ITestAssets testAsset)
        {
            this.billingService = billingService;
            this.testAsset = testAsset;
            controller = new OrderController(billingService);
        }

        [Fact]
        public void ProcessOrder_FineOrder_ReturnsResultWithReceipt()
        {
            var order = testAsset.GetFineOrderForService_A();
            var actual = controller.ProcessOrder(order);
            var expected = testAsset.GetPaymentResultForPaymentService_A();

            Assert.Equal(expected.Receipt.Details, actual.Receipt.Details);
        }

        [Fact]
        public void ProcessOrder_BadOrder_ReturnsResultWithError()
        {
            var order = testAsset.GetOrderWithWrongGateway();
            var actual = controller.ProcessOrder(order);
            var expected = testAsset.GetPaymentResultWithError();

            Assert.Equal(expected.ErrorMessage, actual.ErrorMessage);
        }

    }
}

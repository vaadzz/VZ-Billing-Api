using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using VZ.Billing.BusinessLayer.Services;
using VZ.Billing.BusinessLayer.Services.Implementation;
using VZ.Billing.BusinessLayer.Services.Implementation.Payment;
using VZ.Billing.Entities.Enums;
using VZ.Billing.Test.Assets;
using VZ.Billing.Test.Assets.Impl;

namespace VZ.Billing.Test
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IBillingService>(x =>
              new BillingService(SetupPaymentGateways()));
            services.AddTransient<ITestAssets, TestAssets>();
        }

        private Dictionary<PaymentGateway, IPaymentService> SetupPaymentGateways()
        {
            return new Dictionary<PaymentGateway, IPaymentService>()
            {
                {PaymentGateway.PaymentGateway_A, new PaymentService_A() },
                {PaymentGateway.PaymentGateway_B, new PaymentService_B() },
                {PaymentGateway.PaymentGateway_C, new PaymentService_C() },
            };
        }
    }
}

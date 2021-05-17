using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using VZ.Billing.BusinessLayer.Services;
using VZ.Billing.BusinessLayer.Services.Implementation;
using VZ.Billing.BusinessLayer.Services.Implementation.Payment;
using VZ.Billing.Entities.Enums;

namespace VZ.Billing.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<IBillingService>(x => 
                new BillingService(SetupPaymentGateways()));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
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

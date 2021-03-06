using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DapperAndDocker.Services.CustomerOrders;
using DapperAndDocker.Services.CustomerOrders.Queries;
using DapperAndDocker.Services.Customers;
using DapperAndDocker.Services.Customers.Queries;
using DapperAndDocker.Services.ExecuteCommands;
using DapperAndDocker.Services.Items;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DapperAndDocker
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ICustomerRepository, CustomerRepository>();
            services.AddSingleton<ICustomerOrderRepository, CustomerOrderRepository>();
            services.AddSingleton<IItemRepository, ItemRepository>();
            services.AddTransient<ICustomerCommandText, CustomerCommandText>();
            services.AddTransient<ICustomerOrderCommandText, CustomerOrderCommandText>();
            services.AddScoped<IExecuters, Executers>();
            
            services.AddControllers().AddControllersAsServices();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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
    }
}

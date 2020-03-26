using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using DapperAndDocker.Models;
using DapperAndDocker.Services.Customers.Queries;
using DapperAndDocker.Services.ExecuteCommands;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace DapperAndDocker.Services.Customers
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ICustomerCommandText _commandText;
        private readonly IServiceProvider _service;
        private readonly string _connStr;

        public CustomerRepository(IConfiguration configuration, ICustomerCommandText commandText,
            IServiceProvider service)
        {
            _commandText = commandText;
            _service = service;
            _connStr = configuration.GetConnectionString("CustomerOrderViewer");
        }

        public IList<CustomerModel> GetList()
        {
            using var scope = _service.CreateScope();
            var executers = scope.ServiceProvider.GetRequiredService<IExecuters>();

            var query = executers.ExecuteCommand(_connStr, conn => conn.Query<CustomerModel>(_commandText.GetCustomers))
                .ToList();

            return query;
        }
    }
}
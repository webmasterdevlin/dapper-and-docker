using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using DapperAndDocker.Models;
using DapperAndDocker.Services.CustomerOrders.Queries;
using DapperAndDocker.Services.ExecuteCommands;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DapperAndDocker.Services.CustomerOrders
{
    public class CustomerOrderRepository : ICustomerOrderRepository
    {
        private readonly ICustomerOrderCommandText _commandText;
        private readonly IServiceProvider _service;
        private readonly string _connStr;

        public CustomerOrderRepository(IConfiguration configuration, ICustomerOrderCommandText commandText,
           IServiceProvider service)
        {
            _commandText = commandText;
            _connStr = configuration.GetConnectionString("CustomerOrderViewer");
            _service = service;
        }
        
        
        public IList<CustomerOrderDetailModel> GetList()
        {
            using var scope = _service.CreateScope();
            var executers = scope.ServiceProvider.GetRequiredService<IExecuters>();
            var query = executers.ExecuteCommand(_connStr,
                    conn => conn.Query<CustomerOrderDetailModel>(_commandText.GetCustomerOrders))
                .ToList();
        
            return query;
        }
    }
}
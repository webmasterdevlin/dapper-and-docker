using System;
using System.Collections.Generic;
using System.Linq;
using Dapper.Contrib.Extensions;
using DapperAndDocker.Models;
using DapperAndDocker.Services.ExecuteCommands;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DapperAndDocker.Services.Items
{
    public class ItemRepository : IItemRepository
    {
        private readonly IConfiguration _configuration;
        private readonly IServiceProvider _service;
        private readonly string _connStr;
        
        public ItemRepository(IConfiguration configuration, IServiceProvider service)
        {
            _configuration = configuration;
            _service = service;
            _connStr = _configuration.GetConnectionString("CustomerOrderViewer");
        }

        public List<ItemModel> GetList()
        {
            using var scope = _service.CreateScope();
            var executers = scope.ServiceProvider.GetRequiredService<IExecuters>();
            
            var query = executers.ExecuteCommand(_connStr, conn => conn.GetAll<ItemModel>()).ToList();

            return query;
        }
    }
}
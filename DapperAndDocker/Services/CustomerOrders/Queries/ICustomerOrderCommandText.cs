using System.Collections.Generic;
using DapperAndDocker.Models;

namespace DapperAndDocker.Services.CustomerOrders.Queries
{
    public interface ICustomerOrderCommandText
    {
        string GetCustomerOrders  { get; }
        string GetCustomerOrderById { get; }
        string AddCustomer { get; }
        string UpdateCustomer { get; }
        string RemoveCustomer { get; }
    }
}
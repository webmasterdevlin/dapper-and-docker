using System.Collections.Generic;
using DapperAndDocker.Models;

namespace DapperAndDocker.Services.CustomerOrders
{
    public interface ICustomerOrderRepository
    {
        IList<CustomerOrderDetailModel> GetList();
    }
}
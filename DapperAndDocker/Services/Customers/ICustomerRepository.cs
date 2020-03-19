using System.Collections.Generic;
using DapperAndDocker.Models;

namespace DapperAndDocker.Services.Customers
{
    public interface ICustomerRepository
    {
        IList<CustomerModel> GetList();
    }
}
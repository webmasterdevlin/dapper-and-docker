namespace DapperAndDocker.Services.Customers.Queries
{
    public class CustomerCommandText : ICustomerCommandText
    {
        public string GetCustomers => "Customer_GetList";
        public string GetCustomerById => "";
        public string AddCustomer => "";
        public string UpdateCustomer => "";
        public string RemoveCustomer => "";
    }
}
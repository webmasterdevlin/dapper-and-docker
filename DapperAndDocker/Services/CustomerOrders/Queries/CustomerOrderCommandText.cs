namespace DapperAndDocker.Services.CustomerOrders.Queries
{
    /// <summary>
    /// Using SQL Queries
    /// </summary>
    public class CustomerOrderCommandText : ICustomerOrderCommandText
    {
        public string GetCustomerOrders => "SELECT * FROM CustomerOrder";
        public string GetCustomerOrderById => "";
        public string AddCustomer => "";
        public string UpdateCustomer => "";
        public string RemoveCustomer => "";
    }
}
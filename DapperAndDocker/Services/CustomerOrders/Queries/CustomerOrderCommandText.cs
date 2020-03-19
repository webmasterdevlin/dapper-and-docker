namespace DapperAndDocker.Services.CustomerOrders.Queries
{
    public class CustomerOrderCommandText : ICustomerOrderCommandText
    {
        public string GetCustomerOrders => "CustomerOrderDetail_GetList";
        public string GetCustomerOrderById => "";
        public string AddCustomer => "";
        public string UpdateCustomer => "";
        public string RemoveCustomer => "";
    }
}
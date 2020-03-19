namespace DapperAndDocker.Services.Customers.Queries
{
    public interface ICustomerCommandText
    {
        string GetCustomers { get; }
       string GetCustomerById { get; }
        string AddCustomer { get; }
        string UpdateCustomer { get; }
        string RemoveCustomer { get; }
    }
}
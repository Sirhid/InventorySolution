using HRIS.Application.DTOs.Customer;
using System.Collections.Generic;

namespace HRIS.Application.Interfaces.Repositories
{
    public interface ICustomerService
    {
        int CreateCustomer(CreateCustomerDTO model);
        int UpdateCustomer(UpdateCustomerDTO model);
        int DeleteCustomer(DeleteCustomerDTO model);
        List<CustomerDTO> GetAllCustomer();
        CustomerDTO GetCustomerById(int CustomerId);
    }
}

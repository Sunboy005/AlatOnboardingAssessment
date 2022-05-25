using AlatAssessment.Application.Helpers;
using AlatAssessment.Entity.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AlatAssessment.Application.Services.Interfaces
{
    public interface IUserService
    {
        Task<Response<CustomerResponseDto>> RegisterCustomer(AddCustomerDto model);
        Task<Response<PaginatorHelper<IEnumerable<CustomerResponseDto>>>> GetCustomersAsync(int pageSize = 10, int pageNumber = 1);
        Task<Response<string>> ConfirmCustomer(string otp, string customerId);
    }
}

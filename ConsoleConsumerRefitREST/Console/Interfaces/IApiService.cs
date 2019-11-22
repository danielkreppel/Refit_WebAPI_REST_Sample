using Common.Models;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SampleApp.Interfaces
{
    /// <summary>
    /// This interface uses Refit to set the requests to the Web API
    /// </summary>
    public interface IApiService
    {
        #region Customers

        [Get("/api/mock/customers")]
        [Headers("Authorization: Bearer")]
        Task<IEnumerable<Customer>> GetCustomersAsync();

        [Post("/api/mock/customers")]
        [Headers("Authorization: Bearer")]
        Task<ResponseMessage> SaveCustomerAsync(Customer customer);

        #endregion

    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using EnsekSolution.Core.Models;

namespace EnsekSolution.WebApi.Services
{
    public interface ICustomerAccountsService
    {
        /// <summary>
        /// Gets the customer accounts.
        /// </summary>
        /// <returns>List of customer accounts</returns>
        List<CustomerAccount> GetCustomerAccounts();

        /// <summary>
        /// Gets the customer account by account ID.
        /// </summary>
        /// <returns>Customer account</returns>
        CustomerAccount GetCustomerAccountByAccountId(int accountId);
    }
}

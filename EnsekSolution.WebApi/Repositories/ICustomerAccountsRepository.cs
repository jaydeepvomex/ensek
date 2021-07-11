using System.Collections.Generic;
using System.Threading.Tasks;
using EnsekSolution.Core.Models;

namespace EnsekSolution.WebApi.Repositories
{
    /// <summary>
    /// Defines the repository for accessing the customer accounts.
    /// </summary>
    public interface ICustomerAccountsRepository
    {
        /// <summary>
        /// Gets all customer accounts.
        /// </summary>
        /// <returns>List of customer accounts</returns>
        List<CustomerAccount> GetCustomerAccounts();

        /// <summary>
        /// Get customer account by account ID
        /// </summary>
        /// <param name="accountId">The account ID</param>
        /// <returns>Get the customer account by account ID</returns>
        CustomerAccount GetCustomerAccountByAccountId(int accountId);
    }
}

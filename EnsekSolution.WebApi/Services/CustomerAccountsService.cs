using System.Collections.Generic;
using System.Threading.Tasks;
using EnsekSolution.Core.Models;
using EnsekSolution.WebApi.Repositories;

namespace EnsekSolution.WebApi.Services
{
    /// <summary>
    /// Defines the customer accounts service.
    /// </summary>
    public class CustomerAccountsService : ICustomerAccountsService
    {
        private readonly ICustomerAccountsRepository _customerAccountsRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerAccountsService"/> class.
        /// </summary>
        /// <param name="customerAccountsRepository">The customer account repository.</param>
        public CustomerAccountsService(ICustomerAccountsRepository customerAccountsRepository)
        {
            _customerAccountsRepository = customerAccountsRepository;
        }

        public CustomerAccount GetCustomerAccountByAccountId(int accountId)
        {
            return _customerAccountsRepository.GetCustomerAccountByAccountId(accountId);
        }

        public List<CustomerAccount> GetCustomerAccounts()
        {
            return _customerAccountsRepository.GetCustomerAccounts();
        }
    }
}

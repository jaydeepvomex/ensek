using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnsekSolution.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace EnsekSolution.WebApi.Repositories
{
    /// <summary>
    /// Defines the repository to access customer accounts.
    /// </summary>
    public class CustomerAccountsRepository : ICustomerAccountsRepository
    {
        private readonly EnsekEnergyDbContext _ensekEnergyDbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerAccountsRepository"/> class.
        /// </summary>
        public CustomerAccountsRepository(EnsekEnergyDbContext ensekEnergyDbContext)
        {
            _ensekEnergyDbContext = ensekEnergyDbContext;
        }

        /// <inheritdoc>
        public CustomerAccount GetCustomerAccountByAccountId(int accountId)
        {
            return _ensekEnergyDbContext.CustomerAccounts
                .FirstOrDefault(x => x.AccountId == accountId);
        }

        /// <inheritdoc>
        public List<CustomerAccount> GetCustomerAccounts()
        {
            return _ensekEnergyDbContext.CustomerAccounts.ToList();
        }
    }
}

using System.Collections.Generic;
using EnsekSolution.Core.Models;
using EnsekSolution.WebApi.Repositories;
using EnsekSolution.WebApi.Services;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace EnsekSolution.UnitTesting.Services
{
    [TestClass]
    public class CutomerAccountServiceTests
    {
        private CustomerAccountsService _customerAccountService;
        private readonly Mock<ICustomerAccountsRepository> _customerAccountRepository = new Mock<ICustomerAccountsRepository>();

        public CutomerAccountServiceTests()
        {
            _customerAccountService = new CustomerAccountsService(_customerAccountRepository.Object);
        }

        [TestMethod]
        public void GetCustomerAccountsReturnsListOfCustomerAccounts()
        {
            // Arrange
            var customerAccounts = new List<CustomerAccount>
            {
                new CustomerAccount()
                {
                    AccountId = 1,
                    Firstname = "Tom",
                    Lastname = "Test"
                },

                new CustomerAccount()
                {
                    AccountId = 2,
                    Firstname = "Josh",
                    Lastname = "Test"
                }
            };

            _customerAccountRepository.Setup(x => x.GetCustomerAccounts()).Returns(customerAccounts);

            // Act
            var result = _customerAccountService.GetCustomerAccounts();

            // Assert
            result.Should().NotBeNull();
            result.Count.Should().Be(2);
            result[0].AccountId.Should().Be(1);
            result[0].Firstname.Should().Be("Tom");
            result[0].Lastname.Should().Be("Test");
            result[1].AccountId.Should().Be(2);
            result[1].Firstname.Should().Be("Josh");
            result[1].Lastname.Should().Be("Test");
        }

        [TestMethod]
        public void GetCustomerAccountByAccountIdReturnsCustomerAccount()
        {
            // Arrange
            var customerAccounts = new List<CustomerAccount>
            {
                new CustomerAccount()
                {
                    AccountId = 1,
                    Firstname = "Tom",
                    Lastname = "Test"
                },

                new CustomerAccount()
                {
                    AccountId = 2,
                    Firstname = "Josh",
                    Lastname = "Test"
                }
            };

            _customerAccountRepository.Setup(x => x.GetCustomerAccountByAccountId(1)).Returns(customerAccounts[0]);

            // Act
            var result = _customerAccountService.GetCustomerAccountByAccountId(1);

            // Assert
            result.Should().NotBeNull();
            result.AccountId.Should().Be(1);
            result.Firstname.Should().Be("Tom");
            result.Lastname.Should().Be("Test");
        }

    }
}

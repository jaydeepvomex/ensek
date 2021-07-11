using System.Collections.Generic;
using EnsekSolution.Core.Models;

namespace EnsekSolution.WebApi.Repositories
{
    /// <summary>
    /// Defines the repository for accessing the meter readings.
    /// </summary>
    public interface IMeterReadingRepository
    {
        /// <summary>
        /// Adds the meter reading for the customers.
        /// </summary>
        /// <param name="meterReading">List of meter readings.</param>
        /// <returns>Returns the flag indicating whether the meter reading was sucessfully 
        /// added to the customer account.</returns>
        bool AddCustomerMeterReadings(List<MeterReading> meterReading);

        /// <summary>
        /// Gets the individual meter reading by account ID
        /// </summary>
        /// <param name="accountId">The account Id</param>
        /// <returns>Meter reading for given account ID</returns>
        MeterReading GetMeterReadingByAccountId(int accountId);
    }
}
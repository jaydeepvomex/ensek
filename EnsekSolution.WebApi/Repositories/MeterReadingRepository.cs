using System.Collections.Generic;
using System.Linq;
using EnsekSolution.Core.Models;

namespace EnsekSolution.WebApi.Repositories
{
    public class MeterReadingRepository : IMeterReadingRepository
    {
        private readonly EnsekEnergyDbContext _ensekEnergyDbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="MeterReadingRepository"/> class.
        /// </summary>
        public MeterReadingRepository(EnsekEnergyDbContext ensekEnergyDbContext)
        {
            _ensekEnergyDbContext = ensekEnergyDbContext;
        }

        public bool AddCustomerMeterReadings(List<MeterReading> meterReadings)
        {
            _ensekEnergyDbContext.MeterReadings.AddRange(meterReadings);
            return _ensekEnergyDbContext.SaveChanges() == 1;
        }

        public MeterReading GetMeterReadingByAccountId(int accountId)
        {
            return _ensekEnergyDbContext.MeterReadings.Where(x => x.AccountId == accountId).FirstOrDefault();
        }
    }
}

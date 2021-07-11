using System.Collections.Generic;
using EnsekSolution.Core.Models;
using EnsekSolution.WebApi.Repositories;

namespace EnsekSolution.WebApi.Services
{
    public class MeterReadingService : IMeterReadingService
    {
        private readonly IMeterReadingRepository _meterReadingRepository;

        public MeterReadingService(IMeterReadingRepository meterReadingRepository)
        {
            _meterReadingRepository = meterReadingRepository;
        }

        public bool AddMeterReadings(List<MeterReading> meterReadings)
        {
            _meterReadingRepository.AddCustomerMeterReadings(meterReadings);

            return true;
        }

        public MeterReading GetMeterReadingByAccountId(int accountId)
        {
            return _meterReadingRepository.GetMeterReadingByAccountId(accountId);
        }
    }
}

using System.Collections.Generic;
using EnsekSolution.Core.Models;

namespace EnsekSolution.WebApi.Services
{
    public interface IMeterReadingService
    {
        bool AddMeterReadings(List<MeterReading> meterReadings);

        MeterReading GetMeterReadingByAccountId(int accountId);
    }
}

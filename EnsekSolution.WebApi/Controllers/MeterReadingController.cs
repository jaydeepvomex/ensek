using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using EnsekSolution.Core.Models;
using EnsekSolution.WebApi.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EnsekSolution.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors("MyPolicy")]
    public class MeterReadingController : ControllerBase
    {
        private readonly ILogger<MeterReadingController> _logger;
        private readonly IMeterReadingService _meterReadingService;
        private readonly ICustomerAccountsService _customerAccountsService;

        /// <summary>
        /// Api controller to manage the meter readings.
        /// </summary>
        /// <param name="logger">Logger to log issues.</param>
        /// <param name="meterReadingService">Meter reading service</param>
        /// <param name="customerAccountsService">Customer accounts service</param>
        public MeterReadingController(ILogger<MeterReadingController> logger, 
            IMeterReadingService meterReadingService,
            ICustomerAccountsService customerAccountsService)
        {
            _logger = logger;
            _meterReadingService = meterReadingService;
            _customerAccountsService = customerAccountsService;
        }

        [HttpGet]
        [Route("{accountId:int}")]
        public MeterReading GetMeterReadingByAccountId(int accountId)
        {
            return _meterReadingService.GetMeterReadingByAccountId(accountId);
        }

        [HttpPost("meter-reading-uploads")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UploadMeterReadingsAsync()
        {
            var formCollection = await Request.ReadFormAsync();
            var file = formCollection.Files.First();

            if (file == null)
            {
                return BadRequest();
            }

            var meterReadings = new List<MeterReading>();
            var meterReadingResult = new MeterReadingResult
            {
                SuccessfulCount = 0,
                FailureCount = 0
            };

            var allCustomerAccounts = _customerAccountsService.GetCustomerAccounts();

            if (file.FileName != null)
            {
                string path = Path.Combine("Uploads");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                string fileName = Path.GetFileName(file.FileName);
                string filePath = Path.Combine(path, fileName);
                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                using var fs = new StreamReader(filePath);
                using (var csv = new CsvReader(fs, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<CsvMeterReadingLine>();
                    foreach (var meterReading in records)
                    {
                        var isNumeric = int.TryParse(meterReading.MeterReadValue, out int n);
                        
                        if (isNumeric)
                        {
                            if (meterReading.AccountId > 0 && Convert.ToInt32(meterReading.MeterReadValue) > 0
                            && Convert.ToInt32(meterReading.MeterReadValue) <= 99999)
                            {
                                if (allCustomerAccounts.Any(x => x.AccountId == meterReading.AccountId))
                                {
                                    meterReadings.Add(new MeterReading()
                                    {
                                        AccountId = meterReading.AccountId,
                                        MeterReadingDateTime = Convert.ToDateTime(meterReading.MeterReadingDateTime),
                                        MeterReadValue = Convert.ToInt32(meterReading.MeterReadValue)
                                    });
                                }
                            }
                        } 
                        else
                        {
                            meterReadingResult.FailureCount++;
                        }
                    }

                    meterReadings = meterReadings.GroupBy(x => x.AccountId).Select(x => x.First()).ToList();

                    meterReadingResult.SuccessfulCount = meterReadings.Count;

                    _meterReadingService.AddMeterReadings(meterReadings);
                }
            }
            
            return Ok(meterReadingResult);
        }
    }
}

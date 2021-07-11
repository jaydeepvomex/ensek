using System;
using System.Collections.Generic;
using System.Text;
using CsvHelper.Configuration.Attributes;

namespace EnsekSolution.Core.Models
{
    public class CsvMeterReadingLine
    {
        [Index(0)]
        public int AccountId { get; set; }

        [Index(1)]
        public string MeterReadingDateTime { get; set; }

        [Index(2)]
        public string MeterReadValue { get; set; }
    }
}

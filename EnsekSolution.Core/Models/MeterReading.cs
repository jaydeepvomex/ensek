using System;
using System.ComponentModel.DataAnnotations;

namespace EnsekSolution.Core.Models
{
    /// <summary>
    /// The meter reading object.
    /// </summary>
    public class MeterReading
    {
        [Key]
        /// <summary>
        /// The meter reading ID
        /// </summary>
        public int MeterReadingId { get; set; }

        /// <summary>
        /// The account ID of the customer.
        /// </summary>
        public int AccountId { get; set; }

        /// <summary>
        /// The datetime when the meter reading was taken.
        /// </summary>
        public DateTime MeterReadingDateTime { get; set; }

        /// <summary>
        /// The actual meter reading value.
        /// </summary>
        public int MeterReadValue { get; set; }
    }
}

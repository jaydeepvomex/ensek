using System.ComponentModel.DataAnnotations;

namespace EnsekSolution.Core.Models
{
    /// <summary>
    /// The customer account object.
    /// </summary>
    public class CustomerAccount
    {
        [Key]
        /// <summary>
        /// The account ID of the customer account.
        /// </summary>
        public int AccountId { get; set; }

        /// <summary>
        /// The firstname of the customer.
        /// </summary>
        public string Firstname { get; set; }
        
        /// <summary>
        /// The lastname of the customer.
        /// </summary>
        public string Lastname { get; set; }
    }
}

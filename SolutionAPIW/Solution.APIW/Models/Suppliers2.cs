using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Solution.APIW.Models
{
    public class Suppliers2
    {
        [Key]
        public int? SupplierID { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string ContactName { get; set; }
        [Required]
        public string ContactTitle { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Region { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Fax { get; set; }
        [Required]
        public string HomePage { get; set; }

    }
}

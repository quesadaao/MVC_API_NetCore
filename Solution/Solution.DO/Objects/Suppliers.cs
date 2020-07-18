using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Solution.DO.Objects
{
    public class Suppliers
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

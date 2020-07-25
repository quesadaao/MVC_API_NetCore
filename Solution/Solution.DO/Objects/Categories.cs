using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Solution.DO.Objects
{
    public class Categories
    {
        //public Categories()
        //{
        //    Products = new HashSet<Products>();
        //}
        [Key]
        public int? CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        //public virtual ICollection<Products> Products { get; set; }
    }
}

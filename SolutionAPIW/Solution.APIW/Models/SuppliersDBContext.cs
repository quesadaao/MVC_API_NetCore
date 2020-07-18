using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solution.APIW.Models
{
    public class SuppliersDBContext : DbContext
    {
        public SuppliersDBContext() { }
        public SuppliersDBContext(DbContextOptions<SuppliersDBContext> options) : base(options)
        {

        }

        public virtual DbSet<Suppliers2> suppliers2 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=SCIIV2;Database=Northwind2;User Id=sa;Password=oracle;");
            }
        }
    }
}

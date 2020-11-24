using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirst.Infrastructure.Models
{
   public class SaleItem
    {
        public int SaleItemNumber { get; set; }
        public Product ProductName { get; set; }
        public int SaleItemCount { get; set; }

    }
}

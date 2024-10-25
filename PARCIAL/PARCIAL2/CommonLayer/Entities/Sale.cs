using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class Sale
    {
        public int SaleID { get; set; }         
        public DateTime SaleDate { get; set; }   
        public int Quantity { get; set; }         
        public decimal TotalAmount { get; set; }  
        public int CarID { get; set; }         
    }
}

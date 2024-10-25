using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class Car
    {
        public int CarID { get; set; }
        public string Model { get; set; } = "No reconocido";
        public decimal Price { get; set; }
    }
}

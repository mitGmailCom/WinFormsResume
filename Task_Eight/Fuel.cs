using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Eight
{
    public class Fuel
    {
        public string NameFuel { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{NameFuel} Price = {Price}";
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Eight
{
    public class Cafe
    {
        public string NameProduct { get; set; }
        public double PriceProduct { get; set; }
        public override string ToString()
        {
            return $"{NameProduct} {PriceProduct}";
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dollar.Entities
{
    internal class Rate
    {
        public static double DollarRealRate;

        public static double TotalValue(double amount)
        {
            return 1.06 * amount * DollarRealRate;
        }
    }
}

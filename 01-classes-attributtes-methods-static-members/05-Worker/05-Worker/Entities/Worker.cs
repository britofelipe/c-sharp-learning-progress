using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Worker.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public double GrossSalary { get; set; }
        public double Taxes { get; set; }

        public double NetSalary()
        {
            return GrossSalary - Taxes;
        }

        public void IncrementSalary(double percentage)
        {
            GrossSalary = GrossSalary*(1+(percentage/100));
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkerContracts.Entities.Enums;

namespace WorkerContracts.Entities
{
    internal class Worker
    {
        public string Name { get; protected set; }
        public WorkerLevel Level { get; protected set; }
        public double BaseSalary { get; protected set; }
        public Department Department { get; protected set; }
        public List<HourContract> Contracts { get; protected set; } = new List<HourContract>();

        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }


        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double totalIncomeFromContracts = 0;

            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    totalIncomeFromContracts += contract.TotalValue();
                }
            }
            return totalIncomeFromContracts + BaseSalary;
        }
    }
}

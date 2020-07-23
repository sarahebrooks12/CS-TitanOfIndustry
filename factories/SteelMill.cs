using System;
using System.Collections.Generic;

namespace titan_of_industry
{
    public class SteelMill : IFactory<SteelWorker>
    {
        public int minimumEmployeeCount { get; set; }
        public int maximumEmployeeCount { get; set; }
        public List<SteelWorker> steelWorkers { get; set; } = new List<SteelWorker>();
        public void hireEmployee(SteelWorker employeeToAdd)
        { 
            if(steelWorkers.Count < maximumEmployeeCount){
                steelWorkers.Add(employeeToAdd);
            } else {
                Console.WriteLine("You'll have to fire someone first!");
            }
        }

        public void hireEmployees(SteelWorker employeesToAdd)
        {
             if(steelWorkers.Count < maximumEmployeeCount){
                steelWorkers.Add(employeesToAdd);
            } else {
                Console.WriteLine("You'll have to fire someone first!");
            }
        }
    }
}
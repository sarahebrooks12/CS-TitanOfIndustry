
using System;
using System.Collections.Generic;

namespace titan_of_industry
{
    public class AutoFactory : IFactory<AutoWorker>
    {
        public int minimumEmployeeCount { get; set; }
        public int maximumEmployeeCount { get; set; }
        public List<AutoWorker> autoWorkers {get; set;} = new List<AutoWorker>();

        public void hireEmployee(AutoWorker employeeToAdd)
        {
            if(autoWorkers.Count < maximumEmployeeCount){
                autoWorkers.Add(employeeToAdd);
            } else {
                Console.WriteLine("You'll have to fire someone first!");
            }
        }

        public void hireEmployees(AutoWorker employeesToAdd)
        {
            if(autoWorkers.Count < maximumEmployeeCount){
                autoWorkers.Add(employeesToAdd);
            } else {
                Console.WriteLine("You'll have to fire someone first!");
            };
        }
    }
}
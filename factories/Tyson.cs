using System;
using System.Collections.Generic;

namespace titan_of_industry
{
    public class Tyson : IFactory<FoodProcessor>
    {
        public int minimumEmployeeCount { get; set; }
        public int maximumEmployeeCount { get; set; }
        public List<FoodProcessor> foodWorkers { get; set; } = new List<FoodProcessor>();

        public void hireEmployee(FoodProcessor employeeToAdd)
        {
             if(foodWorkers.Count < maximumEmployeeCount){
                foodWorkers.Add(employeeToAdd);
            } else {
                Console.WriteLine("You'll have to fire someone first!");
            }
        }

        public void hireEmployees(FoodProcessor employeesToAdd)
        {
             if(foodWorkers.Count < maximumEmployeeCount){
                foodWorkers.Add(employeesToAdd);
            } else {
                Console.WriteLine("You'll have to fire someone first!");
            }
        }
    }
}
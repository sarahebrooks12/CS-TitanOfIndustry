using System;

namespace titan_of_industry
{


    public interface IFactory<T>
    {
        public int minimumEmployeeCount { get; set; }
        public int maximumEmployeeCount { get; set; }
        void hireEmployee(T employeeToAdd);
        void hireEmployees(T employeesToAdd);
    }
}
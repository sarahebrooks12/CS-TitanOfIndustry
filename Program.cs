using System;

// If the user selects option 1, they should be presented with a list of factories. When they select a factory from the list, they should see all of the workers at that factory printed to the console.
// If the user selects option 2, they should see a list of possible factories where they could hire an employee. Once they select a factory, they should be prompted for first name, last name, and pay rate. The hire date of the employee should be added automatically. Once they enter the new worker's information, that worker should be added to the appropriate factory, and they should be shown a confirmation message.
namespace titan_of_industry {
    class Program
    {
        static void Main(string[] args)
        {
           SteelWorker andy = new SteelWorker(){
               FullName = "Andy Grammer",
               hireDate = "7/23/2020",
               payRate = 18.00
           };
           FoodProcessor jimmy = new FoodProcessor(){
               FullName = "Jimmy Simpson",
               hireDate = "7/23/2020",
               payRate = 15.50
           };
           AutoWorker alanis = new AutoWorker(){
               FullName = "Alanis Morissette",
               hireDate = "7/23/20",
               payRate = 19.50
           };
        AutoFactory buildACar = new AutoFactory(){
            minimumEmployeeCount = 5,
            maximumEmployeeCount = 25
        };
        SteelMill huntingtonSteel = new SteelMill(){
            minimumEmployeeCount = 10,
            maximumEmployeeCount = 50
        };
        Tyson chickieNuggies = new Tyson(){
            minimumEmployeeCount = 25,
            maximumEmployeeCount = 100
        };
            chickieNuggies.hireEmployee(jimmy);
            buildACar.hireEmployee(alanis);
            huntingtonSteel.hireEmployee(andy);
Console.WriteLine();
// CLI
            Console.WriteLine("Welcome to H.E. Pennypacker Industries!");
            Console.WriteLine("1. View employees at a factory");
            Console.WriteLine("2. Hire a new employee");
            string response = Console.ReadLine();
            if (response == "1"){
                Console.WriteLine(chickieNuggies);
            }
        }
    }
}

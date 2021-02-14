using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulationsOnEmployees
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creation of a database of 20 employees
            Repository repository = new Repository(30);

            // Printing to the console of all employees
            repository.Print("Database before conversion");

               Console.ReadLine();

            // Dismissal of all employees named "George"
            repository.DeleteWorkerByName("George");

            // Printing to the console of employees who were not fired
            repository.Print("Database after first conversion");

               Console.ReadLine();

            // Dismissal of all employees named "Leonardo"
            repository.DeleteWorkerByName("Leonardo");

            // Printing to the console of employees who were not fired
            repository.Print("Database after second conversion");

            Console.ReadLine();

        }
    }
}

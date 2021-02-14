using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulationsOnEmployees
{

    /// <summary>
    /// Organization of data storage and generation
    /// </summary>
    class Repository
    {
        /// <summary>
        /// Database  First Names
        /// </summary>
        static readonly string[] firstNames;

        /// <summary>
        /// Database Last Names
        /// </summary>
        static readonly string[] lastNames;

        /// <summary>
        /// Pseudo-random number generator
        /// </summary>
        static Random randomize;

        /// <summary>
        /// Static constructor, which is "stored"
        /// first and last name's data. Database's firstNames и lastNames
        /// </summary>
        static Repository()
        {
            randomize = new Random(); // Placement of a random number generator in memory

            // Placing names in the firstNames database
            firstNames = new string[] {
                "Lucy",
                "Peter",
                "George",
                "Leonardo",
                "Adam",
                "Mary",
                "Anna",
            };

            // Placing names in the lastNames database 
            lastNames = new string[]
            {
                "Peterson",
                "Anderson",
                "Simpson",
                "Smith",
                "Polkaton",
                "Bloomberon",
                "Patinson",
                "Letto",
                "Jolly",
                "Pitt",
                "Tarantino",
                "Messi",
                "Ronaldo",
                "Benz",
                "Hakasima",
                "Husquarna",
                "Strix",
                "Soodine",
                "Martinson",
                "Allabinus",
                "Hella"
            };
        }

        /// <summary>
        /// Employee database, which saves
        /// Name, last name, age and salary of each employee
        /// </summary>
        public List<Worker> Workers { get; set; }

        /// <summary>
        /// Constructor that write's the Workers database
        /// </summary>
        /// <param name="Count">Number of employees to create</param>
        public Repository(int Count)
        {
            this.Workers = new List<Worker>(); // Allocating memory for storing the Workers database

            for (int i = 0; i < Count; i++)    // Populating the Workers database. Runs 'Count' times
            {
                // Add a new worker to the Workers database
                this.Workers.Add(
                    new Worker(
                        // choose a random name from the firstNames database
                        firstNames[Repository.randomize.Next(Repository.firstNames.Length)],
                        
                        // choose a random name from the lastNames database
                        lastNames[Repository.randomize.Next(Repository.lastNames.Length)],

                        // Generating a random age in the range of 19 years - 60 years
                        randomize.Next(19, 60),

                        // Generating a random age in the range of 19 years - 60 years Generating a random salary in the range of 10,000 USD - 80,000 USD
                        randomize.Next(10000, 80000)
                        ));
            }
        }

        /// <summary>
        /// Method for outputting the Workers database to the console
        /// </summary>
        /// <param name="Text">Auxiliary text that will be printed before the base output</param>
        public void Print(string Text)
        {
            Console.WriteLine(Text);    // Printing Help Text to the Console

            // Change the font color for printing in the console to Dark Blue
            Console.ForegroundColor = ConsoleColor.DarkBlue; 

            // Displaying Database Column Headers
            Console.WriteLine($"{"First Name",15} {"Last Name",15} {"Age",10} {"Salary",15}");

            // Displaying the headings of the base columns and changing the font color for printing in the console on Gray data
            Console.ForegroundColor = ConsoleColor.Gray;

            
            foreach (var worker in this.Workers) //
            {                                    // Print Workers
                Console.WriteLine(worker);       //
            }                                    //

            Console.WriteLine($"Result: {this.Workers.Count}\n");    // How many workers have been printed
        }

        /// <summary>
        /// Method that fires workers with more than a specified salary
        /// </summary>
        /// <param name="MaxSalary">The salary level of the employee to be fired</param>
        public void DeleteWorkerBySalary(int MaxSalary)
        {
            this.Workers.RemoveAll(e => e.Salary > MaxSalary);//Removing employees whose salary is higher than the specified MaxSalary
        }

        /// <summary>
        /// Method that fires workers with a given FirstName
        /// </summary>
        /// <param name="CurrentName">Name of employees to be fired</param>
        public void DeleteWorkerByName(string CurrentName)
        {
            this.Workers.RemoveAll(e => e.FirstName == CurrentName);//Removing workers whose name matches the selected CurrentName
        }
    }
}

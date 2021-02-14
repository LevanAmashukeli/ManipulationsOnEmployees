using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulationsOnEmployees
{
    /// <summary>
    /// Class describing the worker model
    /// </summary>
    class Worker
    {
        /// <summary>
        /// Employee's FirstName
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Employee's LastName
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Employee's Age
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Employee's Salary
        /// </summary>
        public int Salary { get; set; }

        /// <summary>
        /// A constructor that allows you to assign a value to the corresponding employee fields
        /// </summary>
        /// <param name="FirstName">First Name</param>
        /// <param name="LastName">Last Name</param>
        /// <param name="Age">Age</param>
        /// <param name="Salary">Salary</param>
        public Worker(string FirstName, string LastName, int Age, int Salary)
        {
            this.FirstName = FirstName; // Save passed FirstName value
            this.LastName = LastName;   // Save passed LastName value
            this.Age = Age;             // Save passed Age value
            this.Salary = Salary;       // Save passed Salary value
        }

        /// <summary>
        /// Organization of the output of information about the employee
        /// </summary>
        /// <returns>String representation of information</returns>
        public override string ToString()
        {
            return $"{FirstName,15} {LastName,15} {Age,10} {Salary.ToString("## ###"),10} USD.";
        }
    }
}
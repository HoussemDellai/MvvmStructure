using System.Collections.Generic;
using MvvmFiles.Models;

namespace MvvmFiles.Services
{
    public class EmployeesServices
    {

        /// <summary>
        /// Gets a list of all the employees.
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetEmployees()
        {
            var employees = new List<Employee>
            {
                new Employee
                {
                    Name = "Hassen Ali",
                    Department = "Human Resources",
                },
                new Employee
                {
                    Name = "Mohamed Hussein",
                    Department = "IT Department",
                },
                new Employee
                {
                    Name = "Seif Abdallah",
                    Department = "Marketing",
                },
                  new Employee
                {
                    Name = "Marwen Samih",
                    Department = "Human Resources",
                },
                new Employee
                {
                    Name = "Ahmed Rabiaa",
                    Department = "IT Department",
                },
                new Employee
                {
                    Name = "Othman Anouar",
                    Department = "Marketing",
                },
            };

            return employees;
        } 
    }
}

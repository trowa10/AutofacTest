﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacBasic
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public void Print(Employee employee)
        {
            Console.WriteLine("Printing Employee");
            Console.WriteLine(string.Format("Employee Id : {0}", employee.EmployeeId));
            Console.WriteLine(string.Format("First Name : {0}", employee.FirstName));
            Console.WriteLine(string.Format("Last Name : {0}", employee.LastName));
            Console.WriteLine(string.Format("Designation : {0}", employee.Designation));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacBasic
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeerRepository)
        {
            _employeeRepository = employeerRepository;
        }

        public void Print(Employee employee)
        {
            _employeeRepository.Print(employee);
        }
    }
}

using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = BuildContainer();
            var employeeService = container.Resolve<IEmployeeService>();
            Employee employee = new Employee
            {
                EmployeeId = 1,
                FirstName = "Jalpesh",
                LastName = "Vadgama",
                Designation = "Technical Architect"
            };
            employeeService.Print(employee);
            Console.ReadKey();
        }
        static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<EmployeeRepository>().As<IEmployeeRepository>().InstancePerLifetimeScope();
            builder.RegisterType<EmployeeService>().As<IEmployeeService>().InstancePerLifetimeScope();
            return builder.Build();
        }

    }
}

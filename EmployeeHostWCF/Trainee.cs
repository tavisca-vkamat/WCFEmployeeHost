using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeWCF
{
    public class Trainee : IEmployee
    {
        public static List<Employee> dataEmployees;
        
        Trainee()
        {
            dataEmployees = new List<Employee>();
            dataEmployees.Add(new Employee("1","vivek","kamat",DateTime.Now.AddMonths(-20),1000.10));
            dataEmployees.Add(new Employee("2", "john", "abraham", DateTime.Now.AddMonths(-50), 2000.10));
            dataEmployees.Add(new Employee("3", "salman", "khan", DateTime.Now.AddMonths(-10), 3000.10));
            dataEmployees.Add(new Employee("4", "amir", "khan", DateTime.Now.AddMonths(-1), 4000.10));
        }

       
        public Employee GetEmployee(string id)
        {
            return dataEmployees.FirstOrDefault(e => e.id.Equals(id));
        }

        public double SalaryCalculator(string id)
        {
            Employee employee =  dataEmployees.FirstOrDefault(e => e.id.Equals(id));
            return employee.salary * 0.5 + employee.salary;
        }

        public void SaveEmployee(Employee employee)
        {
            dataEmployees.Add(employee);
        }
    }
}

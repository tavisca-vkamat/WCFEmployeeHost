using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace EmployeeWCF
{
  
    public class Employee
    {
        public Employee() { }

        public Employee(string id, string firstName, string lastName, DateTime dateOfJoining, double salary)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfJoining = dateOfJoining;
            this.salary = salary;
        }
        
      
        public string id { get; set; }

       
        public string firstName { get; set; }

        public string lastName { get; set; }

      
        public DateTime dateOfJoining { get; set; }

 
        public double salary { get; set; }
    }


    [ServiceContract]
    public interface IEmployee
    {
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml, UriTemplate = "id/{id}")]
        [OperationContract]
        Employee GetEmployee(string id);

        [OperationContract]
        void SaveEmployee(Employee employee);
        
        [OperationContract]
        double SalaryCalculator(string id);
    }
}

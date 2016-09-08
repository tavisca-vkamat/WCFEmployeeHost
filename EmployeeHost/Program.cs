using System;
using System.ServiceModel;

namespace EmployeeHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host1 = new ServiceHost(typeof(EmployeeWCF.Trainee));
            host1.Open();
            

            using (ServiceHost host = new ServiceHost(typeof(EmployeeWCF.Manager)))
            {
                host.Open();
                Console.WriteLine($"WCF service starts at {DateTime.Now}");
                Console.ReadLine();
            }
            host1.Close();
            
        }
    }
}

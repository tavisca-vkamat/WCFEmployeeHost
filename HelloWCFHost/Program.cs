using System;
using System.ServiceModel;
namespace HelloWCFHost
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(HelloWCF.HelloToWCF)))
            {
                host.Open();

                Console.WriteLine($"servise started at: {DateTime.Now}");

                Console.ReadLine();
            }
        }
    }
}

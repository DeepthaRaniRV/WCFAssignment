using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using CardInfoLibrary;

namespace HostingSelf
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(CdInfo));
            host.Open();
            Console.WriteLine("Server Started..");
            Console.WriteLine("Press any key to start server..");
            Console.ReadLine();
        }
    }
}

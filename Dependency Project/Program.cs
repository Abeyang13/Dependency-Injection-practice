using System;
using System.Collections.Generic;

namespace Dependency_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Abraham", "Yang");
            ServiceManager service = new ServiceManager(new PhoneService());
            service.ServiceCustomer(client);
        }
    }
}

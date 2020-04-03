using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Project
{
    class PhoneService : IService
    {
        public void Installation(Client client)
        {
            Console.WriteLine($"{client.firstName} {client.lastName}, Your Phone Service Is Installed");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Project
{
    class CableService : IService
    {
        public void Installation(Client client)
        {
            Console.WriteLine($"{client.firstName} {client.lastName}, Your Cable Service Is Installed");
        }
    }
}

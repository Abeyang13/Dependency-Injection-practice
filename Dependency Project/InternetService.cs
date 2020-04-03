using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Project
{
    class InternetService : IService
    {
        public void Installation(Client client)
        {
            Console.WriteLine($"{client.firstName} {client.lastName}, Your Internet Service Is Installed");
        }
    }
}

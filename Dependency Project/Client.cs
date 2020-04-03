using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Project
{
    class Client
    {
        public string firstName;
        public string lastName;


        public Client(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}

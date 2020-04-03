using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Project
{
    public class Message : ISendable
    {
        public void Send()
        {
            Console.WriteLine("Message Sent");
        }
    }
}

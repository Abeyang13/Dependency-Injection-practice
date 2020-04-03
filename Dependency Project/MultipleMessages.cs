using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Project
{
    public class MultipleMessages : ISendable
    {
        List<string> message = new List<string> { "Hey", "The", "Where" };
        public void Send()
        {
            foreach ( var messages in message)
            {
                Console.WriteLine(messages);
            }
        }
    }
}

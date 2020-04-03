using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Project
{
    class MessageController
    {
        private ISendable sendable;

        public MessageController(ISendable sendable)
        {
            this.sendable = sendable;
        }

        public void SendMessage()
        {
            sendable.Send();
        }
    }
}

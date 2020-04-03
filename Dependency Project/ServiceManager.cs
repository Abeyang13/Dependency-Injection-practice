using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Project
{
    class ServiceManager
    {
        IService _service;
        public ServiceManager(IService service)
        {
            _service = service;
        }

        public void ServiceCustomer(Client client)
        {
            _service.Installation(client);
        }
    }
}

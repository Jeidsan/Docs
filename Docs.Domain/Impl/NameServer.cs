using Docs.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Docs.Domain.Impl
{
    public class NameServer : INameServer
    {
        Dictionary<Guid, string> INameServer.GetProcesses()
        {
            throw new NotImplementedException();
        }

        Dictionary<Guid, string> INameServer.GetResources()
        {
            throw new NotImplementedException();
        }

        Guid INameServer.Register(IProcess process, string uri)
        {
            throw new NotImplementedException();
        }

        Guid INameServer.Register(IResource resource, string uri)
        {
            throw new NotImplementedException();
        }

        void INameServer.Unregister(Guid identifier)
        {
            throw new NotImplementedException();
        }
    }
}

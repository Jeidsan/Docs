using System;
using System.Collections.Generic;
using System.Text;

namespace Docs.Domain.Base
{
    /// <summary>
    /// Especifica os serviços mínimos que devem ser oferecido por um recurso.
    /// </summary>
    public interface IResource
    {        
        bool View();

        bool Edit();

        bool Save();
    }
}
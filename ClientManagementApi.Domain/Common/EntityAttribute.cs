using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagementApi.Domain.Common
{
    [AttributeUsage(AttributeTargets.Class,Inherited = false, AllowMultiple = false)]
    public sealed class EntityAttribute : Attribute
    {
        
    }
}

 
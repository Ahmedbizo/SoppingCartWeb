using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common.Interfaces
{
    public interface IBusinessManagerFactory
    {
        T GetBusinessManager<T>() where T : IBusinessManager;
    }
}

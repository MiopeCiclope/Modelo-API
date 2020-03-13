using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandBoxAPI.Interfaces
{
    public interface IService<T> where T : class, IEntity
    {
    }
}

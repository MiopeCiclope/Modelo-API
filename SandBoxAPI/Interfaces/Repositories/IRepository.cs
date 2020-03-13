﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandBoxAPI.Interfaces.Repositories
{
    public interface IRepository<T> where T : class, IEntity
    {
        List<T> GetAll();
        T Get(int id);
        T Add(T entity);
        T Update(T entity);
        T Delete(int id);
    }
}

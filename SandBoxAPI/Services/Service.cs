using Microsoft.EntityFrameworkCore;
using SandBoxAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandBoxAPI.Services
{
    public abstract class Service<TEntity, TContext> : IService<TEntity>
        where TEntity : class, IEntity
        where TContext : DbContext
    {
        private readonly TContext context;
        public Service(TContext context)
        {
            this.context = context;
        }
    }
}

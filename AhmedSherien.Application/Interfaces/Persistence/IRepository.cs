using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AhmedSherien.Application.Interfaces.Persistence
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Remove(T entity);
    }
}

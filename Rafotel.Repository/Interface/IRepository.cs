using System;
using System.Collections.Generic;
using System.Text;

namespace Rafotel.Repository.Interface
{
    public interface IRepository<T>
    {
        bool Add(T obj);
        List<T> GetList();
        T Get(long id);
    }
}

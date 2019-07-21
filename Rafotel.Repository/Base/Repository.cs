using Rafotel.Domain.Interfaces;
using Rafotel.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rafotel.Repository.Base
{
    public abstract class Repository<T> : IRepository<T> where T : IEntity
    {
        private static List<T> _list;
        private static object _syncObj = new object();

        protected Repository()
        {
            //Singleton pattern
            if (_list == null)
            {
                lock (_syncObj)
                {
                    if (_list == null)
                    {
                        _list = new List<T>();
                    }
                }
            }

        }
        public bool Add(T obj)
        {
            _list.Add(obj);
            return true;
        }

        public T Get(long id)
        {
            return _list.SingleOrDefault(w => w.Id == id);
        }

        public List<T> GetList()
        {
            return _list;
        }
    }
}
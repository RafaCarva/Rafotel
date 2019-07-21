using System;
using System.Collections.Generic;
using System.Text;
using Rafotel.Domain.Interfaces;

namespace Rafotel.Domain.Base
{
    public abstract class Entity : IEntity
    {
        public long Id { get; set; }
        public Guid Key { get; set; }
    }
}
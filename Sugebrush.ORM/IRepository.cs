using System;
using System.Collections;
using System.Collections.Generic;

namespace Sugebrush.ORM
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Get(Guid id);
        ICollection<T> GetCollection();

        // TODO: Define and implements other methods
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    internal interface IRepository<TEntity>
    {
        public TEntity GetByID(Guid id);
        public TEntity Add(TEntity person);
        public TEntity UpDate(TEntity person);
        public void Delete(Guid id);
    }
}

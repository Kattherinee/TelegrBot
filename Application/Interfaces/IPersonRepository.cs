using System;
using System.Collections.Generic;
using System.Text;
using Domain.entities;

namespace Application.Interfaces
{
    internal interface IPersonRepository : IRepository<Person>
    {
        public List<CustomField<string>> GetCustomFields();
    }
}

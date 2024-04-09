using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    /// <summary>
    /// описать 
    /// </summary>
    public class FullName : BaseValueObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? MiddleName { get; set; } = null; //использовали лэйбл-тип, допустим как null
       
        public FullName(string firstname, string lastname, string middlename)
        {
            FirstName = firstname;
            LastName = lastname;
            MiddleName = middlename;
        }
    }
}

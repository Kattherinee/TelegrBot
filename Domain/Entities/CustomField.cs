using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.entities
{
    public class CustomField<TValue> : BaseEntity
    { /// <summary>
      /// имя
      /// </summary>
        public CustomField()
        {
            //TODO: ПРОВАЛИДИРОВАТЬ
        }
        public string Name { get; set; }
        public TValue Value { get; set; }
    }
}

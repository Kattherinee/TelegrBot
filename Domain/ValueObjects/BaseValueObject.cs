using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
   public abstract class BaseValueObject
    {
        /// <summary>
        /// TODO: Найти и реализовать глубокое сравнение DeepClone(), DeepCompare()
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj) 
        {
            return base.Equals(obj);
        }
        public override int GetHashCode() 
        {
            return base.GetHashCode();
        }
    }
}

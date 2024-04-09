using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.entities
{
    /// <summary>
    /// Базовый класс для всех сущностей
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Уникальный идентификатор сущностей
        /// </summary>
        protected Guid ID { get; set; }

        /// <summary>
        /// Дата создания сущности
        /// </summary>
        protected DateTime CreateDate { get; set;}

        /// <summary>
        /// метод для сравнения сущности по id
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is BaseEntity entity)) return false;
            if (ID != ((BaseEntity)obj).ID) return false;
            return true;
        }

        /// <summary>
        /// почему нужно переoпределить GetHashCode
        /// Если не переопределить, то постоянно айдишка постоянно будет разной
        /// создаём это случайное число, опираясь на свойство айди,хотим чтобы хэшкод генерировался в зависимости от того, какой айдишник
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
           return ID.GetHashCode();    
        }
    }


}

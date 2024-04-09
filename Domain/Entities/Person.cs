using Domain.ValueObjects;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Domain.Primitivities;
using Domain.ValueObjects;

namespace Domain.entities
{
    /// <summary>
    /// основная сущность персоны 
    /// </summary>
    public class Person : BaseEntity
    { 
        public Person(FullName fullName, DateTime birthDate,  string phoneNumber, string telegram)
        { 
            FullName = ValidateFullName(fullName);
            BirthDate = ValidateBirthDate(birthDate);
            PhoneNumber = ValidatePhoneNumber(phoneNumber);
            Telegram = ValidateTelegram(telegram);

          ///TODO: *FluentValidator (изучить, но не обязательно)
        }

        public FullName FullName { get; private set; } //имеем теперь полноценное инкапсулированное поле фуллнейм
        public DateTime BirthDate { get; set; }   //сделала Для DateTime валидация 150 лет максимум 
        public int Age => DateTime.Now.Year - BirthDate.Year;  
        public Gender gender { get; set; }   //Gender проверка не undefined
        public string PhoneNumber { get; set; } //сделала
        /// <summary>
        /// УЧЕСТЬ! 
        /// ДОЛЖНО БЫТЬ: +, 373, 5 цифр
        /// НЕ ДОЛЖНО БЫТЬ: 123 
        /// </summary>
        public string Telegram { get; private set; } //сделала Валидация по полюшку Telegram - есть собачка ник не больше 35 символов,
       
        
        public List<CustomField<string>> CustomFields { get; set; }

        private FullName ValidateFullName(FullName fullname)
        {
            /// <summary>
            /// TODO: Добавить валидацию, допускающую только русские и английские буквы
            /// </summary>
          
            if (string.IsNullOrEmpty(fullname.FirstName) ||
                string.IsNullOrEmpty(fullname.LastName))
            { 
                throw new ValidationException(ValidationMessages.NullOrEmpty("имя или фамилия")); 
            }

            if (fullname.MiddleName is null)
            {
                throw new ValidationException(ValidationMessages.NullOrEmpty("отчество"));
            }

            var checkFullName = new Regex(@"^[а-яА-Яa-zA-Z]+$");

            if (!checkFullName.IsMatch(fullname.FirstName))
            {
                throw new ValidationException(ValidationMessages.InvalidCharacter("Имя"));
            }
            else if (!checkFullName.IsMatch(fullname.LastName))
            {
                throw new ValidationException(ValidationMessages.InvalidCharacter("Фамилия"));
            }
            else if (!checkFullName.IsMatch(fullname.MiddleName))
            {
                throw new ValidationException(ValidationMessages.InvalidCharacter("Отчество"));
            }

            return fullname;
        }

        private DateTime ValidateBirthDate (DateTime birthDate)
        {

            if (birthDate > DateTime.Now)
            {
                throw new ValidationException(ValidationMessages.FutureDateNotAllowed("Дата рождения"));
            }

            if (DateTime.Now.Year - birthDate.Year > 150)
            {
                throw new ValidationException(ValidationMessages.AgeLimit(150));
            }

            return birthDate;
        }

        private string ValidatePhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
            {
                throw new ValidationException(ValidationMessages.NullOrEmpty("Номер телефона"));
            }
         
            var checkPhone = new Regex(@"^\+373(77[4-9]|562)\d{5}$");

            if (!checkPhone.IsMatch(phoneNumber))
            {
                throw new ValidationException(ValidationMessages.InvalidPhoneNumberFormat());
            }

            return phoneNumber;
        }

        private string ValidateTelegram (string tg)
        {
            if (string.IsNullOrEmpty(tg))
            {
                throw new ValidationException(ValidationMessages.NullOrEmpty("Telegram"));
            }

            var checkTelegram = new Regex(@"^@?[a-zA-Z0-9_]{5,32}$");

            if (!checkTelegram.IsMatch(tg))
            {
                throw new ValidationException(ValidationMessages.InvalidTelegramUserName());
            }
            return tg; 
        }
    }
}

//    !!  TODO: ВАЛИДАЦИЯ ДЛЯ ВСЕХ ПОЛЕЙ  (пометки выше)  

using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Primitivities
{
    public static class ValidationMessages
    {   /// <summary>
        /// TODO: cделать ошибки шаблонными (StringBuilder. StringFormatter)
        /// для того чтобы понимать где что сломалось
        /// </summary>
        // public static string NullOrEmpty = "Объект {object} не может быть Null";

        public static string NullOrEmpty(string fio)
        {
            return string.Format("Поле {0} не может быть неопределённым. ", fio);
        }
        public static string InvalidCharacter(string language)
        {
            return string.Format("Поле {0} содержит недопустимые символы.", language);
        }

        public static string FutureDateNotAllowed(string fieldName)
        {
            return string.Format("Поле {0} не может быть в будущем.", fieldName);
        }

        public static string AgeLimit(int limit)
        {
            return string.Format("Возраст не может превышать {0} лет.", limit);
        }
        public static string InvalidPhoneNumberFormat()
        {
            return "Номер телефона должен быть в формате '+373 - 5 цифр'.";
        }

      /*  public static string UndefinedGender(string gender)
        {
            return string.Format("Поле {0} не может быть неопределённым. ", gender);
        }
      */

        public static string InvalidTelegramUserName()
        {
            return "Поле user name должно начинаться с '@' и содержать от 5 до 32 символов (a-zA-Z0-9_).";
        }
    }
 }
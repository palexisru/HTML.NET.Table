using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using pl2.table.tuple;

namespace pl2.table.domain.primary
{
    /// <summary>
    /// перечисление типов базы данных для описания в базе
    /// </summary>
    public enum Type_enum
    {
        Autoincrement = 'A', // первичный целочисленный ключ в схеме базы данных из генератора Scheme_system
        Character = 'C', // строка символов 
        Date = 'D',      // дата и время: ггггммддччммсс
        Integral = 'I',  // дамп целого в шестнадцатеричной строке
        Keep = 'K',      // дата и время удаления записи ггггммддччммсс - первое поле в каждой таблице
        Logical = 'L',   // 0 = false, 1 true
        Numeric = 'N',   // число в виде строки
        Password = 'P',  // шифруемая строка
        Real = 'R',      // вещественное в шестнадцатеричной строке
        Scheme = 'S',    // схема - имя в описании схемы данных
        Tuple = 'T'      // таблица - имя в описании схемы данных 
    }

    /// <summary>
    /// Комонент - прототип поля для классов хранения данных с метаданными для формы
    /// </summary>
    public class Domain : Component
    {
        public const int max_field_name_lenght_constant = 32;
        public const int max_url_path_lenght_constant = 256;
        public const int max_number_length_constant = 8;

        /// <summary>
        /// имя поля
        /// </summary>
        public string field_name;

        /// <summary>
        /// тип поля
        /// </summary>
        public Type_enum field_type;

        /// <summary>
        /// длина_поля в байтах
        /// </summary>
        public int field_size;

        /// <summary>
        /// количество десятичных знаков
        /// </summary>
        public int field_decimal;

        [Browsable(false)]
        /// <summary>
        /// запрос на ввод значения для поля
        /// </summary>
        public string prompt(string message = "Введите данные")
        {
            return message;
        }
    }

}

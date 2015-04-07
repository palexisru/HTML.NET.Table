using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using pl2.table.tuple;

namespace pl2.table.dl.db.domain
{
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
        public Domain_enum field_type;

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using pl2.table.domain.primary;

namespace pl2.table.tuple
{
    /// <summary>
    /// Прототип для классов хранения данных формы
    /// </summary>
    public class Tuple_tuple : Domain
    {
        private string field_name_inner;
        private Type_enum field_type_inner;
        private Int32 field_len_inner;
        private Int32 field_decimal_inner;

        [Browsable(true), Description("Имя поля"), Category("Data")]
        public string field_name { get { return field_name_inner; } }

        [Browsable(true), Description("Тип поля"), Category("Data")]
        public Type_enum field_type { get { return field_type_inner; } }

        [Browsable(true), Description("Длина поля общая"), Category("Data")]
        public Int32 field_len { get { return field_len_inner; } }

        [Browsable(true), Description("Количество десятичных знаков"), Category("Data")]
        public Int32 field_dec { get { return field_decimal_inner; } }

        public Tuple_tuple()
        {
        }

        public Tuple_tuple(string field_name_new, Type_enum field_type_new, Int32 field_len_new, Int32 field_dec_new)
        {
            field_name_inner = field_name_new;
            field_type_inner = field_type_new;
            field_len_inner = (field_len_new < 1) ? 1 : field_len_new;
            field_decimal_inner = (field_dec_new > field_len_inner - 2) ? field_len_inner - 2 : field_dec_new;
        }
    }
}

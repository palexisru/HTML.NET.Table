using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using pl2.table.tuple;

namespace pl2.table.domain
{

    [Flags]
    public enum Access_position_enumerate
    {
        Nothing = 0x0,
        Find = 0x1,
        Read = 0x2,
        Write = 0x4,
        Create = 0x8,
        Delete = 0x10,
        Modify = 0x20,
        Admin = 0x3F
    }

    /// <summary>
    /// поле прав на объекты схемы
    /// F - просмотр имени таблицы или полей
    /// R - чтение записей
    /// W - запись изменений
    /// C - создание новых таблиц
    /// D - удаление таблиц
    /// M - изменение структуры таблиц
    /// </summary>
    public class Access_domain : Tuple_tuple
    {

        public const string grand_constant = "FRWCDM";
        public const string deny_constant = "frwcdm";
        public const string empty_string = "      ";
        private string field_value_private;

        [Browsable(true), Description(""), Category("Data")]
        public string field_value { get; set; }

        [Browsable(true), Description(""), Category("Data")]
        public string _values { get; set; }

        [Browsable(true), Description(""), Category("Data")]
        public Access_domain()
        {
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using pl2.table.domain;

namespace pl2.table.tuple
    {
        /// <summary>
        /// Прототип для классов хранения данных формы
        /// </summary>
        public class Tuple_tuple  : Domain_tuple
        {
            [Browsable( true ) , Description( "Имя поля" ) , Category( "Data" )]
            public readonly string field_name { get; set; }

            [Browsable( true ) , Description( "Тип поля" ) , Category( "Data" )]
            public readonly Type_enum field_type { get; set; }

            [Browsable( true ) , Description( "Длина поля общая" ) , Category( "Data" )]
            public readonly int field_len { get; set; }

            [Browsable( true ) , Description( "Количество десятичных знаков" ) , Category( "Data" )]
            public readonly string field_dec { get; set; }
        }
    }

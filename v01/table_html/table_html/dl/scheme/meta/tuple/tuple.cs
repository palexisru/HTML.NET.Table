using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using pl2.table.domain;

    namespace pl2.table.meta.tuple
    {
        /// <summary>
        /// запись в таблице Scheme с информацией о полях базы данных
        /// </summary>
        class Tuple
        {
            [Browsable( true ) , Description( "Имя таблицы схемы данных" ) , Category( "Data" )]
            public string table_name { get; set; }

            [Browsable( true ) , Description( "Имя поля таблицы данных" ) , Category( "Data" )]
            public string field_name { get; set; }

            [Browsable( true ) , Description( "Позиция в таблице" ) , Category( "Data" )]
            public int field_pos { get; set; }

            [Browsable(true), Description("Длина поля"), Category("Data")]
            public int field_len { get; set; }

            [Browsable(true), Description("Количество знаков для округления"), Category("Data")]
            public string field_dec { get; set; }

            [Browsable(true), Description("Заголовок в табличном режиме"), Category("Data")]
            public string header { get; set; }

            [Browsable( true ) , Description( "Описание поля" ) , Category( "Data" )]
            public string caption { get; set; }

            [Browsable( true ) , Description( "Схема данных ссылочного ключа" ) , Category( "Data" )]
            public string look_scheme { get; set; }

            [Browsable(true), Description("Таблица данных ссылочного ключа"), Category("Data")]
            public string look_table { get; set; }

            [Browsable(true), Description("Поле данных ссылочного ключа"), Category("Data")]
            public string look_field { get; set; }

            [Browsable(true), Description("Поле расшифровки по ключу"), Category("Data")]
            public string disp_field { get; set; }

        }
    }

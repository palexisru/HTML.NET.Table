using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using pl2.table.domain.primary;

namespace pl2.table.dl.scheme
    {
        /// <summary>
        /// запись базы данных для описания схемы в базе
        /// </summary>
        public class Scheme : Domain
        {
            [Browsable( true ) , Description( "название схемы данных" ) , Category( "Data" )]
            public string schema { get; set; }

            [Browsable( true ) , Description( "путь к схеме данных" ) , Category( "Data" )]
            public string source { get; set; }

            [Browsable( true ) , Description( "доступ только на чтение" ) , Category( "Data" )]
            public bool read_only { get; set; }
        }
    }

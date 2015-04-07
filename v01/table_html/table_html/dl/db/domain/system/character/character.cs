using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using pl2.table.tuple;

namespace pl2.table.domain
{
    /// <summary>
    /// строчное поле
    /// </summary>
    public class Character_domain : Tuple_tuple
    {
        public Character_domain()
        { 
        }

        [Browsable( true ) , Description( "Строчное_значение" ) , Category( "Data" )]
        public string field_value { get; set; }
        }

    }

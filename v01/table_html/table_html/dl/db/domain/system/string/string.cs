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
    public class String_domain : Tuple_tuple
    {
        public String_domain()
        { 
        }

        [Browsable( true ) , Description( "Строчное_значение" ) , Category( "Data" )]
        public string field_value { get; set; }
        }

    }

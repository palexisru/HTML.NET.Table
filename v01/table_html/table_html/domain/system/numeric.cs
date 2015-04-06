using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using pl2.table.tuple;
using pl2.table.domain.primary;

namespace pl2.table.domain
    {
    /// <summary>
    /// поле числового типа с записью символами без ведущих пробелов
    /// при переполнении точность понижается или используется экспоненциальная форма
    /// </summary>
    public class Numeric_domain : Tuple_tuple
        {
        [Browsable( true ) , Description( "" ) , Category( "Data" )]
        public string field_value { get; set; }

        [Browsable( true ) , Description( "" ) , Category( "Data" )]
        public long integer_value { get; set; }

        [Browsable( true ) , Description( "" ) , Category( "Data" )]
        public Double real_value { get; set; }

        [Browsable( true ) , Description( "" ) , Category( "Data" )]
        public Numeric_domain(string field_name_new, int field_len_new, int field_dec_new)
            :base(field_name_new, Type_enum.Numeric, field_len_new, field_dec_new)
        { 
            real_value = 0;
        }


    }
}

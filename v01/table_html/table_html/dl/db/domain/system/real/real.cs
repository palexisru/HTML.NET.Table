using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using pl2.table.tuple;
using pl2.table.dl.db.domain;

namespace pl2.table.domain
    {
    /// <summary>
    /// поле
    /// </summary>
    public class Real_domain : Tuple_tuple
        {
            private Single real_value_inner;

        [Browsable( true ) , Description( "" ) , Category( "Data" )]
        public Single field_value { 
            get{ return real_value_inner; }
            set {real_value_inner = value; } 
        }

        // [Browsable( true ) , Description( "" ) , Category( "Data" )]
        // public strinf _values { get; set; }
        public Real_domain(string field_name_new):base(field_name_new, Domain_enum.Real, 8, 255)
        {
            field_value = Single.NaN;
        }
    }
}

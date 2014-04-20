using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using pl2.table.tuple;

namespace pl2.table.domain
    {
    /// <summary>
    /// поле
    /// </summary>
    public class Date_domain : Component
        {
        public const string empty_string_const = "000000000000000";
        public Date_domain(string field_name_new){
            field_name_new = field_name_new;
            field_value = empty_string_const;
        }

        [Browsable( true ) , Description( "" ) , Category( "Data" )]
        public string field_value { get; set; }

        [Browsable( true ) , Description( "" ) , Category( "Data" )]
        public strinf _values { get; set; }

        }
    }

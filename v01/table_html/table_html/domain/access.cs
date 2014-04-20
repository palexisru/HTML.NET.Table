using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using pl2.table.domain;

namespace pl2.table.domain
    {

    public enum Access_position_enumerate
    {
        Find = 0,
        Read = 1,
        Write = 2,
        Create = 3,
        Delete = 4,
        Modify = 5
    }

    /// <summary>
    /// поле
    /// </summary>
    public class Access_domain : Tuple_tuple
        {
        public const string grand_constant = "VRWCDM";
        public const string deny_constant = "vrwcdm";
        public const string empty_string = "      ";
        private string field_value_private;

        [Browsable( true ) , Description( "" ) , Category( "Data" )]
        public string field_value { get; set; }

        [Browsable( true ) , Description( "" ) , Category( "Data" )]
        public strinf _values { get; set; }

        [Browsable( true ) , Description( "" ) , Category( "Data" )]
        public Access_domain() { 
         }

        }
    }

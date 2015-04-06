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
    public class Integer_domain : Component
        {
        public const string empty_integer_string = "00000000";

        public const Int32 NaN = Int32.MinValue;
        public const Int32 NegativeInfinity = Int32.MinValue + 1;
        public const Int32 PositiveInfinity = Int32.MaxValue;
        public const Int32 MinValue = Int32.MinValue + 2;
        public const Int32 MaxValue = Int32.MaxValue - 1;

        [Browsable( true ) , Description( "" ) , Category( "Data" )]
        public string field_value { get; set; }
        
        [Browsable( true ) , Description( "" ) , Category( "Data" )]
        public string field_value1 { get; set; }

        [Browsable( true ) , Description( "" ) , Category( "Data" )]
        public string _values { get; set; }

        }
    }

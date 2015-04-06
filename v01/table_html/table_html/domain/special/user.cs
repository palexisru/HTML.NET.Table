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
    /// поле 
    /// </summary>
    public class User_domain : Tuple_tuple
    {
        [Browsable(true), Description(""), Category("Data")]
        public string field_value { get; set; }

        [Browsable(true), Description(""), Category("Data")]
        public string _values { get; set; }

        [Browsable(true), Description(""), Category("Data")]
        public User_domain(string field_name_new)
            : base(field_name_new, Type_enum.Password, max_field_name_lenght_constant, 0)
        {
        }

    }
}

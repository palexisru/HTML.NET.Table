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
    public class Scheme_domain : Tuple_tuple
    {

        private string field_value_private = new String(' ', max_field_name_lenght_constant);
        private string url_private = new String(' ', max_url_path_lenght_constant);

        [Browsable(true), Description(""), Category("Data")]
        public string field_value { get { return field_value_private; } }

        [Browsable(true), Description(""), Category("Data")]
        public string url_value { get { return url_private; } }

    }
}

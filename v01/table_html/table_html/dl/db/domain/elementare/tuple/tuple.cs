using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using pl2.table.dl.db.domain;
using pl2.table.dl.db.domain.system.integer;
using pl2.table.tuple;

namespace pl2.table.dl.db.domain.elementare.tuple
{
    /// <summary>
    /// поле с именем таблицы
    /// </summary>
    public class Tuple : Tuple_tuple
    {
        private Int32 tuple_id_private = Integer_domain.MinValue;
        private string table_name_private = new String(' ', max_field_name_lenght_constant);
        private string field_name_private = new String(' ', max_field_name_lenght_constant);

        [Browsable(true), Description(""), Category("Data")]
        public string field_value { get; set; }

        [Browsable(true), Description(""), Category("Data")]
        public string table_name { get { return table_name_private; } }

        [Browsable(true), Description(""), Category("Data")]
        public string field_name { get { return field_name_private; } }

        public Tuple(string field_name_new)
            : base(field_name_new, Domain_enum.Tuple, max_number_length_constant, 0)
        {
            // read_scheme_meta(this);
        }

    }
}

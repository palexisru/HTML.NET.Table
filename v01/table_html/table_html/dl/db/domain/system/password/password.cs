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
    /// строчное поле
    /// </summary>
    public class Password_domain : Tuple_tuple
    {
        private string field_value_private = new String(' ', max_field_name_lenght_constant);
        [Browsable(true), Description("Пароль"), Category("Data")]
        public string field_value { get; set; }

        public Password_domain(string field_name_new)
            : base(field_name_new, Domain_enum.Password, max_field_name_lenght_constant, 0)
        {
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pl2.table.tuple;

namespace pl2.table.domain
    {
    /// <summary>
    /// логическое поле
    /// </summary>
    public class Logical_domain : Tuple_tuple
        {
        /// <summary>
        /// Символьное значение для логической истины
        /// </summary>
        public const string true_string_constant = "T";

        /// <summary>
        /// Строка с возможными значениями, отображающими истину
        /// </summary>
        public const string true_string_secondary_constant = "TtYyДдИи";

        /// <summary>
        /// символьное значение для логической лжи
        /// </summary>
        public const string false_string_constant = "F";

        /// <summary>
        /// конструктор логического поля
        /// </summary>
        /// <param name="field_name_new">имя создаваемого поля</param>
        public Logical_domain(string field_name_new)
            {
            this.field_type = Type_enum.Logical;
            this.field_len = 1;
            this.field_dec = 0;
            this.field_name = field_name_new;
            this.field_value = false;
            }

        [Browsable( true ) , Description( "Логическое значение" ) , Category( "Data" )]
        public bool field_value { get; set; }

        [Browsable( true ) , Description( "" ) , Category( "Data" )]
        static explicit operator string(bool master_value)
            {
            return master_value ? true_string_constant : false_string_constant;
            }

        [Browsable( true ) , Description( "" ) , Category( "Data" )]
        static explicit operator string(bool master_value)
            {
            return master_value ? true_string_constant : false_string_constant;
            }

        [Browsable( true ) , Description( "" ) , Category( "Data" )]
        static explicit operator bool(string master_value)
            {
            if (master_value.Length == 0)
                return false;
            return (master_value == true_string_constant)
               || (true_string_secondary_constant.Contains( master_value[0] ));
            }

        }

    }

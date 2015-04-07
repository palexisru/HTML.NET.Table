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
        public Logical_domain(string field_name_new):base(field_name_new, Domain_enum.Logical, 1, 0)
            {
            this.field_value = false;
            }

        [Browsable( true ) , Description( "Логическое значение" ) , Category( "Data" )]
        public bool field_value { get; set; }

        [Browsable( true ) , Description( "" ) , Category( "Data" )]
        public string boolean_to_string(bool master_value)
            {
            return master_value ? true_string_constant : false_string_constant;
            }

        [Browsable( true ) , Description( "" ) , Category( "Data" )]
        public static string boolean_to_string1(bool master_value)
            {
            return master_value ? true_string_constant : false_string_constant;
            }

        [Browsable( true ) , Description( "" ) , Category( "Data" )]
        public static Boolean string_to_boolean(string master_value)
            {
            if (master_value.Length == 0)
                return false;
            return (master_value == true_string_constant)
               || (true_string_secondary_constant.Contains( master_value[0] ));
            }

        }

    }

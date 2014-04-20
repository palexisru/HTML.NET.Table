using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using pl2.table.tuple;

namespace pl2.table.domain
    {
    /// <summary>
    /// поле - дата и время удаления записи
    /// </summary>
    public class Keep_domain : Date_domain
        {
        public const string not_keep_constant = "               ";
        public Keep_domain(): base ("keep"){
            field_value = not_keep_constant;
        }


        }
    }

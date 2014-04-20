using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using pl2.table.tuple;

namespace pl2.table.domain
    {
    /// <summary>
    /// перечисление типов базы данных для описания в базе
    /// </summary>
    public enum Type_enum
        {
        Logical = 'L' ,
        Character = 'C' ,
        Integral = 'I' ,
        Real = 'R' ,
        Numeric = 'N' ,
        Date = 'D' ,
        Tuple = 'T' ,
        Scheme = 'S',
        User = 'U',
        Password = 'P',
        Access = 'A',
        Keep = 'K'
        }

    /// <summary>
    /// Комонент - прототип всех для классов хранения данных сметаданными для формы
    /// </summary>
    public class Domain_tuple : Component
        {
            public const int Max_field_name_lenght_constant = 32;
            public const int Max_url_path_lenght_constant = 256;
            public const int Max_number_length_constant = 8;
            

            [Browsable( false )]
            public void ShowForm(string message = "Введите данные")
            {
            }
        }

    }

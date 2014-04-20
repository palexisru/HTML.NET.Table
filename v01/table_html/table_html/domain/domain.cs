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
        Access = 'A'
        }

    /// <summary>
    /// Прототип для классов хранения данных формы
    /// </summary>
    public class Domain_tuple : Component
        {
            [Browsable( false )]
            public void ShowForm(string message = "Введите данные")
            {
            }
        }

    }

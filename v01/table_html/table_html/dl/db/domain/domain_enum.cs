using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pl2.table.dl.db.domain
{
    /// <summary>
    /// перечисление типов базы данных для описания в базе
    /// </summary>
    public enum Domain_enum
    {
        Autoincrement = 'A', // первичный целочисленный ключ в схеме базы данных из генератора Scheme_system
        Character = 'C', // строка символов 
        Date = 'D',      // дата и время: ггггммддччммсс
        Integral = 'I',  // дамп целого в шестнадцатеричной строке
        Keep = 'K',      // дата и время удаления записи ггггммддччммсс - первое поле в каждой таблице
        Logical = 'L',   // 0 = false, 1 true
        Numeric = 'N',   // число в виде строки
        Password = 'P',  // шифруемая строка
        Real = 'R',      // вещественное в шестнадцатеричной строке
        Scheme = 'S',    // схема - имя в описании схемы данных
        Tuple = 'T'      // таблица - имя в описании схемы данных 
    }

}

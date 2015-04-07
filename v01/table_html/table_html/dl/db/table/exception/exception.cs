using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pl2.table.dl.table.exception
{
    public class Exception : pl2.table.dl.exception.Exception
    {
        public Exception(System.String message)
            : base("Ошибка таблицы данных\n" + message)
        { 
        }
    }
}

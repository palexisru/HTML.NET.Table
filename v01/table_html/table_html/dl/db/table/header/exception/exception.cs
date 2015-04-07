using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pl2.table.dl.table.header.exception
{
    public class Exception : pl2.table.dl.table.exception.Exception
    {
        public Exception(System.String message)
            : base("Ошибка заголовка таблицы HTML\n")
        { 
        }
    }
}

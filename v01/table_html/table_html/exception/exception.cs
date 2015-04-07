using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pl2.table.exception
{
    public class Exception : System.Exception
    {
        public Exception(System.String message)
            : base("Ошибка реляционных таблиц\n" + message) 
        { 
        }

    }
}

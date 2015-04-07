using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pl2.table.dl.exception
{
    public class Exception 
        : pl2.table.exception.Exception
    {
        public Exception(System.String message)
            : base("Ошибка в динамической библиотеке\n" + message)
        { 
        }
    }
}

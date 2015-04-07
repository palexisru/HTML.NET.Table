using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pl2.table.dl.scheme.exception.some
{
    public class Exception : pl2.table.dl.scheme.exception.Exception
    {
        public Exception(System.String message)
            : base("Путь не соответствует предыдущим обновлениям\n" + message)
        { 
        }

    }
}

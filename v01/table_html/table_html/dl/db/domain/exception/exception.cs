using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pl2.table.dl.db.domain.exception
{
    public class Exception : pl2.table.dl.db.exception.Exception
    {
        public Exception(System.String message)
            : base("Ошибка таблицы\n" + message) 
        { 
        }
    }
}

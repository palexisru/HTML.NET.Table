using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pl2.table.dl.fs.file.html.exception
{
    public class Exception 
        : pl2.table.dl.fs.file.exception.Exception
    {
        public Exception(System.String message)
            : base("Ошибка формата HTML")
        { 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pl2.table.dl.scheme.exception
{
    public class Exception : System.Exception
    {
        public Exception(System.String new_text) 
            : base("Ошибка схемы:\n" + new_text)
        {            
        }
    }
}

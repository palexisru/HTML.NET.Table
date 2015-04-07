using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pl2.table.dl.db.domain.system.password.exception
{
    class Exception : System.Exception
    {
        public Exception(System.String message)
            : base("Ошибка ...\n")
        {
        }
    }
}

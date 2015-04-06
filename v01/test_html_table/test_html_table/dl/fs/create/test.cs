using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace pl2.table.dl.fs.create
{
    public class Test
    {
        const System.String directory_name = @"C:\TEMP\TEST";

        public System.Boolean run()
        {
            test_directory_creation(directory_name);
            return true;
        }

        public DirectoryInfo test_directory_creation(System.String new_directory_name)
        {
            return System.IO.Directory.CreateDirectory(new_directory_name);
        }

    }
}

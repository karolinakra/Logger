using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLogger
{
    class Logger
    {
        private readonly string fileName;
        //const string fileName2 = "stala";

        public Logger()
        {

        }
        public Logger(string fileName)
        {
            this.fileName = fileName;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord.Logging
{
    public class Logging : ILogging
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}

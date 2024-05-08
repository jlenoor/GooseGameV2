using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord.Business.Logger
{
    public class Logger : ILogging
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
        public void ClearLog()
        {
            Console.Clear();
        }
        public void NewLine()
        {
            Console.Write(Environment.NewLine);
        }
        public void WaitOnEnterInput()
        {
            Console.ReadLine();
        }
    }
}

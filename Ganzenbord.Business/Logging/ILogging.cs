using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ganzenbord.Business.Logger
{
    public interface ILogging
    {
        void Log(string message);
        public void ClearLog();
        public void NewLine();
        public void WaitOnEnterInput();
        
    }
}
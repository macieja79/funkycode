using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunkyCode
{
    public interface ILogger
    {
        void Log(string message);
        void Log(DateTime dateTime, MessageType typeOfMessage,  string message);
    }
}

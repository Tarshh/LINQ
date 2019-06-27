using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace LINQ
{
    public class ConsoleLogger : ILogger
    {
        public void LogObject(object message)
        {
            Console.WriteLine(message);
        }
    }
}

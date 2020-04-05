using Solid.Followed.Contract;
using System;

namespace Solid.Followed.Concrete
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
            => Console.WriteLine(message);
    }
}

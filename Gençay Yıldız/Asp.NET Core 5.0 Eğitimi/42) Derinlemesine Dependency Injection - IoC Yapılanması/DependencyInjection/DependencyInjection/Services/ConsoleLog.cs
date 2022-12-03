using DependencyInjection.Services.Interfaces;

namespace DependencyInjection.Services
{
    public class ConsoleLog : ILog
    {
        public ConsoleLog(int a)
        {

        }
        public void Log()
        {
            System.Console.WriteLine("Console loglama işlemi gerçekleşti");
        }
    }
}

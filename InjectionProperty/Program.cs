using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InjectionProperty
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[Log]{message}");
        }
    }

    public class MyClass
    {
        public ILogger Logger { get; set; }
        public void DoSomething()
        {
            Logger?.Log("doing something");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.Logger=new ConsoleLogger();
            myClass.DoSomething();
            Console.ReadLine();
        }
    }
}

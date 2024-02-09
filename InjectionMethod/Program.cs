using InjectionMethod.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjectionMethod
{
    public class Service : ISet
    {
        public void print()
        {
            Console.WriteLine("i am printing");
        }
    }
    public class Client
    {
        private ISet _set { get; set; }
        public void Run(ISet serv)
        {
            this._set = serv;
            Console.WriteLine("start");
            this._set.print();

        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.Run(new Service());
            Console.ReadLine();
        }
    }
}

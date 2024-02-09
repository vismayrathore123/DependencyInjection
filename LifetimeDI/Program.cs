using LifetimeDI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace LifetimeDI
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection().
                AddTransient<ITransient, TransientOperation>()
            .AddScoped<IScoped, ScopedOperation>()
            .AddSingleton<ISingleton, SingletonOperation>().BuildServiceProvider();


            Console.WriteLine("=======REquest1======");
            serviceProvider.GetService<ITransient>().Info();
            serviceProvider.Get<ITransient>().Info();
            serviceProvider.Get<IScoped>().Info();
            Console.WriteLine("=======REquest======");

            Console.WriteLine("=======REquest2======");
            serviceProvider.GetService<ITransient>().Info();
            serviceProvider.Get<ITransient>().Info();
            serviceProvider.Get<IScoped>().Info();
            Console.WriteLine("=======REquest======");

            using(var scope = serviceProvider.CreateScope())
            {
                Console.WriteLine("========== Request 3 ============");
                scope.ServiceProvider.GetService<IScoped>().Info();
                scope.ServiceProvider.GetService<ITransient>().Info();
                scope.ServiceProvider.GetService<ISingleton>().Info();
                Console.WriteLine("========== ========= ============");



                Console.WriteLine("========== Request 4 ============");
                scope.ServiceProvider.GetService<IScoped>().Info();
                scope.ServiceProvider.GetService<ISingleton>().Info();
                Console.WriteLine("========== ========= ============");
            }
            using (var scope = serviceProvider.CreateScope())
            {
                Console.WriteLine("========== Request 5 ============");
                scope.ServiceProvider.GetService<IScoped>().Info();
                scope.ServiceProvider.GetService<ISingleton>().Info();
                Console.WriteLine("========== ========= ============");
            }


            Console.WriteLine("========== Request 6 ============");
            serviceProvider.GetService<IScoped>().Info();
            Console.WriteLine("========== ========= ============");

            Console.ReadKey();
        }

        }

    }
}

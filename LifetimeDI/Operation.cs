using LifetimeDI.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifetimeDI
{
    public  abstract class Operation:ISingleton,ITransient,IScoped
    {
        private Guid _operationId;
        private string _lifeTime;

        protected Operation(string lifeTime)
        {
            _lifeTime = lifeTime;
            _operationId = Guid.NewGuid();
            Console.WriteLine($"{_lifeTime} service created");
        }
        public void Info ()
        {
            Console.WriteLine($"{_lifeTime}:{_operationId}");
        }
        
    }
}

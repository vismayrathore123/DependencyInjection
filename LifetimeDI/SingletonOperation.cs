using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifetimeDI
{
    public class SingletonOperation : Operation
    {
        public SingletonOperation() : base("singleton") { }
      
    }
    
}

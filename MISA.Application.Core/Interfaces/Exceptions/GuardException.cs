using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.CukCuk.Core.Interfaces.Exceptions
{
   public class GuardException<Entity> :Exception
    {
        public GuardException(string msg):base(msg)
        {
           
        }
    }
}

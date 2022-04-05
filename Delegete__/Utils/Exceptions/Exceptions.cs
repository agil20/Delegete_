using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Exceptions
{
    internal class Exceptions
    {/*- Exceptions folder
  - CapacityLimitException
  - AlreadyExistsException
  - NotFoundException*/
       public static Exception Capasit()
        {
            throw new Exception("-CapacityLimitException");
        }

        public static Exception Alread()
        {
            throw new Exception(" - AlreadyExistsException");
        }
        public static Exception NotFaund()
        {
            throw new Exception("NotFaundException");
        }
    }
}

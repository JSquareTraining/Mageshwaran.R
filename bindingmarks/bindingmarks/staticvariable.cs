using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bindingmarks
{
   public  class staticvariable
    {
        public static int count;
        public int add(int value)
        {
            count = value;
            return count;
        }
    }
}

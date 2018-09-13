using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbinding
{
    class Odata
    {
        private string Name;
        private double marks;
        public string Uname
        {
            get { return Name; }
            set { Name = value; }

        }
        public double Umarks
        {
            get { return marks; }
            set { marks = value; }
        }

            
    }
   
}

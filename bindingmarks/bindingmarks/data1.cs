using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bindingmarks
{
   public  class data1
    {
        private double _mark1;
        private double _mark2;
        private double _mark3;
        private double _mark4;
        private double _mark5;
        public double Mark1
        {
            get { return _mark1; }
            set { _mark1 = value; }
        }
        public double Mark2
        {
            get { return _mark2; }
            set { _mark2 = value; }
        }
        public double Mark3
        {
            get { return _mark3; }
            set { _mark3 = value; }
        }
        public double Mark4
        {
            get { return _mark4; }
            set { _mark4 = value; }
        }
        public double Mark5
        {
            get { return _mark5; }
            set { _mark5 = value; }
        }
        public int Add ()
        {
            object s = 10;
            string m = s.ToString();

            dynamic i = 10;
            string k = i;

            var mk = 10;
            int hj = mk;


            int a = Convert.ToInt16(Mark1) + Convert.ToInt16(Mark2) + Convert.ToInt16(Mark3) + Convert.ToInt16(Mark4) + Convert.ToInt16(Mark5);
            return a;
        }
        public int sum()
        {
            int b = Convert.ToInt16(Mark1) + Convert.ToInt16(Mark2) + Convert.ToInt16(Mark3) + Convert.ToInt16(Mark4) + Convert.ToInt16(Mark5) / 500;
            return b;
        }


    }
    



}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Class1
    {
        public string Converter(string a){
            int CCount = -1;
            double R = 0;
            foreach (char potato in a){
                CCount++;
            }

            foreach (char potato in a)
            {
                R += double.Parse(potato.ToString()) * Math.Pow(2,CCount);
            }

            return R.ToString();
        }
    }
}

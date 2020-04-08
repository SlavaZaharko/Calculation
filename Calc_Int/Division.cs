using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.Calc_Int
{
    public class Division : ICalc
    {
        public float DoMath(float tmp1, float tmp2)
        {
             return tmp1 / tmp2;
        }
    }
}

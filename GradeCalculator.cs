using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class GradeCalculator
    {
        public static char Calculator(int value)
        {
            if (value >= 70 && value <= 100)
            {
                return 'A';
            }
            else if(value >= 60)
            {
                return 'B';
            }
            else if(value >= 50)
            {
                return 'C';
            }
            else if (value >= 45)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }
    }
}

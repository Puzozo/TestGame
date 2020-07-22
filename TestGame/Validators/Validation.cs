using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame
{
    public class Validation
    {
        public bool IsDigit(string value)
        {
            return int.TryParse(value, out int test);
        }

        public bool IsBiggerThen(int border, int value)
        {
            return value >= border;
        }
        public bool IsLessThen(int border, int value)
        {
            return value <= border;
        }

        public bool IsPermitedAmount(int value)
        {
            return (value % 2 == 1);
        }
    }
}

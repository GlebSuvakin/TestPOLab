using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modules
{
    class NewMassMore
    {
        public static bool IsSimple(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsMore(int num)
        {
            int a = num % 10;
            int b = num / 1000;
            if (b > a)
            {
                return true;
            }
            return false;
        }
    }
}

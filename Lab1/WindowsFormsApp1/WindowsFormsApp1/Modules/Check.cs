using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modules
{
    class Check
    {
        public static bool CheckArrayDimension(int[] array)
        {
            if (array.Length != 10)
            {
                return false;
            }
            return true;
        }

        public static bool CheckCapacity(int[] array)
        {
            foreach (int num in array)
            {
                if (num < 1000 || num > 9999)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CheckPositiveNumber(int[] array)
        {
            foreach (int num in array)
            {
                if (num < 1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

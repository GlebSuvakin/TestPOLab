using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modules
{
    class ArrayParser
    {
        public static string[] StrToArr(string str)
        {
            string[] strArray = str.Split(' ');
            return strArray;
        }
        public static bool IsNumberContains(string input)
        {
            bool flag = true;
            foreach (char c in input)
                if (!Char.IsNumber(c))
                    flag = false;
            return flag;
        }
        public static int[] StrArrToIntArr(string[] strArray)
        {
            int[] array = strArray.Select(n => int.Parse(n)).ToArray();
            return array;
        }
    }
}

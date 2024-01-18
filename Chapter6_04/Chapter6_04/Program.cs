using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string strNumber = "-123";
            int intResult = int.Parse(strNumber);
            System.Diagnostics.Debug.WriteLine(intResult);


            int intNumber = -456;
            string strResult = intNumber.ToString();
            System.Diagnostics.Debug.WriteLine(intResult);
        }

        public static int StrToInt(string str)
        {
            int i = 0, num = 0;
            bool isNeg = false;
            int len = str.Length;

            if (str[0] == '-')
            {
                isNeg = true;
                i = 1;
            }

            while (i < len)
            {
                num *= 10;
                num += (str[i++] - '0');
            }

            if (isNeg)
                num = -num;

            return num;
        }

        public static string IntToStr(int num)
        {
            int i = 0;
            bool isNeg = false;
            char[] temp = new char[11]; // int의 최댓값은 Int32.MaxValue로 2,147,483,647 + 음수기호 추가

            if (num < 0)
            {
                num = -num;
                isNeg = true;
            }

            do
            {
                temp[i++] = (char)((num % 10) + '0');
                num /= 10;
            } while (num != 0);

            StringBuilder result = new StringBuilder();

            if (isNeg)
                result.Append('-');

            while (i > 0)
            {
                result.Append(temp[--i]);
            }

            return result.ToString();
        }
    }
}

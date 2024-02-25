using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodProject
{
    internal static class StatClass
    {
        public static void Test3(this Program p)
        {
            Console.WriteLine("Method3");
        }
        public static long Factorial(this Int32 x)
        {
            if (x == 1) return 1;
            if (x == 2) return 2;
            else
            {
                return x * Factorial(x - 1);  
            }
             
        }
        public static string ToProper(this string OldStr)
        {
            if (OldStr.Trim().Length > 0) { 
                   string NewStr = null;
                   OldStr = OldStr.ToLower();
                   string []arr= OldStr.Split(' ');

                foreach (string str in arr)
                {
                    char[] carr=str.ToCharArray();
                    carr[0] = char.ToUpper(carr[0]);
                    if (NewStr == null)
                    {
                        NewStr = new string(carr);
                    }
                    else
                    {
                        NewStr +=" "+ new string(carr);
                    }
                     
                }
                return NewStr;
            }
            return OldStr; 
        }
    }
}
  
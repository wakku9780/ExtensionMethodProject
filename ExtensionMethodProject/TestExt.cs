using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodProject
{
    internal class TestExt
    {
        static void Main()
        {
            Program p = new Program();
            p.Test3();
            int i = 5;
            long result = i.Factorial();
            Console.WriteLine("Factorial of {0} is: {1}", i, result);

            String str = "hElLo hOw Are yoU ";
            str = str.ToProper();
            Console.WriteLine(str);
            Console.ReadLine();
        }


    }
}

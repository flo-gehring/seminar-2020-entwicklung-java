using System;
using System.Collections.Generic;
namespace Beispielcode
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericTest<int, string> gt = new GenericTest<int, string>();
            gt.genericTypeMethod(1);
            gt.genericTypeMethod("Hallo Welt!");

            GenericTest<int, string>.genericListType(new List<string>());
            GenericTest<int, string>.genericListType(new List<bool>());

            GenericTest<int, string>.statMethod(1);
            GenericTest<int, string>.statMethod(2);

            GenericTest<int, bool>.statMethod(3);

            Console.WriteLine("<int, string>    typeCounter: " + GenericTest<int, string>.typeCounter);
            Console.WriteLine("<int, bool>      typeCounter: " + GenericTest<int, bool>.typeCounter);



        }
    }
}

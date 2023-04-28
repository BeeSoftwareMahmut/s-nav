using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arasınav1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Identity id = new Identity();
            int number = id.InputNumber();
            bool checkNumber = id.checkNumber(number);
            id.PrintCheckedNumber(number, checkNumber);
            Console.ReadKey();
        }
    }
}

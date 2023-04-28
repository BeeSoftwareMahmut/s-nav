using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arasınav1
{
    interface Iidentity
    {
        int InputNumber();
        bool checkNumber(int number);
        void PrintCheckedNumber(int number, bool ısIdentity);
    }
}

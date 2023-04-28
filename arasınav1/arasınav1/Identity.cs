using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arasınav1
{
    class Identity:Iidentity
    {
        private int mnumber;

        public int Mnumber
        {
            get
            {
                return this.mnumber;
            }
            set
            {
                this.mnumber = value;
            }

        }
        public Identity()
        {
        }

        public Identity(int number)
        {
            if (number >= 10000 && number <= 99999)
            {
                this.mnumber = number;
            }
            else
            {
                throw new ArgumentException("The number should be a five-digit integer.");
            }
        }
        public int InputNumber()
        {
            Console.Write("Enter an Identity Number : ");
            this.mnumber = Convert.ToInt32(Console.ReadLine());
            char[] digitOfNumber = this.mnumber.ToString().ToCharArray();

            if(digitOfNumber.Length != 5 || digitOfNumber[0] == '0')
            {
                do
                {
                    Console.Write("Enter an Identity Number : ");
                    this.mnumber = Convert.ToInt32(Console.ReadLine());
                    digitOfNumber = this.mnumber.ToString().ToCharArray();

                } while (digitOfNumber.Length != 5 || digitOfNumber[0] == '0');

            }

            return this.mnumber;
        }
        public bool checkNumber(int number)
        {
            bool isIdentity = true;
            char[] digitOfNumber = number.ToString().ToCharArray();
            int control = ((int.Parse(digitOfNumber[0].ToString()) +int.Parse(digitOfNumber[2].ToString())) * 5 - (int.Parse(digitOfNumber[1].ToString()) + int.Parse(digitOfNumber[3].ToString())))%10;
            if (control != int.Parse(digitOfNumber[4].ToString()))
            {
                isIdentity = false;
            }
            else
            {
                isIdentity = true;
            }
            return isIdentity;
        }

        public void PrintCheckedNumber(int number,bool ısIdentity)
        {
            if (ısIdentity)
            {
                Console.WriteLine("{0} is a valid ıdentity number",number);
            }
            else
            {
                Console.WriteLine("{0} is not  a valid ıdentity number", number);
            }
        }

    }
}

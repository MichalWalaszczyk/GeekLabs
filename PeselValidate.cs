using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeselValidate
{
    class PeselValidate
    {
        private string str1;
        public string getStr1()
        {
            return this.str1;
        }

        public PeselValidate (string str1)
        {
            this.str1 = str1;
        }

        public bool validate(string str1)
        {
            int checkSum = 0;
            string stringOfMultipliers = "1379137913";
            for (int i = 0; i < 10; i++)
            {
                checkSum += int.Parse(stringOfMultipliers[i].ToString()) * int.Parse(str1[i].ToString());
            }
            if ((10 - (checkSum % 10)) == int.Parse(str1[10].ToString()))
            {
                return true;
            }
            return false;
        }
    }
}

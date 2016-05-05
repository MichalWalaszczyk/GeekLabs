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
        public string Str1
        {
            set
            {
                if (this.str1.Length < 10)
                {
                    throw new Exception("Podany numer PESEL jest za krótki. PESEL musi składać się z 11 cyfr.");
                }
                else if (this.str1.Length > 10)
                {
                    throw new Exception("Podany numer PESEL jest za długi. PESEL musi składać się z 11 cyfr.");
                }
                else
                {
                    this.str1 = value;
                }
            }
        }


        public PeselValidate (string str1)
        {
            this.str1 = str1;
        }

        public bool Validate()
        {
            int checkSum = 0;
            string stringOfMultipliers = "1379137913";
            for (int i = 0; i < 10; i++)
            {
                checkSum += int.Parse(stringOfMultipliers[i].ToString()) * int.Parse(this.str1[i].ToString());
            }
            if ((10 - (checkSum % 10)) == int.Parse(this.str1[10].ToString()))
            {
                return true;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnforcingPrivacyWithCryptography
{
    class Encryption
    {
        private int _digit1;
        private int _digit2;
        private int _digit3;
        private int _digit4;

        public int Digit1
        {
            get
            {
                return _digit1;
            }
            set
            {
                _digit1 = SplitDigits(value, 1);
            }
        }
        public int Digit2
        {
            get
            {
                return _digit2;
            }
            set
            {
                _digit2 = SplitDigits(value, 2);
            }
        }
        public int Digit3
        {
            get
            {
                return _digit3;
            }
            set
            {
                _digit3 = SplitDigits(value, 3);
            }
        }
        public int Digit4
        {
            get
            {
                return _digit4;
            }
            set
            {
                _digit4 = SplitDigits(value, 4);
            }
        }

        public Encryption(string number)
        {
            
            if (checkFourDigits(number))
            {
                Digit1 = Convert.ToInt32(number);
                Digit2 = Convert.ToInt32(number);
                Digit3 = Convert.ToInt32(number);
                Digit4 = Convert.ToInt32(number);
               
            }
            else
                throw new Exception("The number you typed was not 4-digit number");
        }

        private bool checkFourDigits(string number)
        {
            if (number.Length != 4)
                return false;
            else
                return true;
        }

        private int SplitDigits(int value, int digit)
        {

            string stringValue = value.ToString();


            int newDigit = Convert.ToInt32(stringValue.Substring(digit - 1, 1));

            return (newDigit + 7) % 10;
        }


        public string EncryptedNumber()
        {
            
            return _digit3.ToString() + _digit4.ToString() + _digit1.ToString() + _digit2.ToString();
        }

        
    }
}

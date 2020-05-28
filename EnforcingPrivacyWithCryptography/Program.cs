using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnforcingPrivacyWithCryptography
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a 4 digit number to encrypt: ");
            var number = Console.ReadLine();

            Encryption Enum = new Encryption(number);
            Console.WriteLine("The number {0} is encrypted to {1}", number, Enum.EncryptedNumber());



           

            Console.Write("Enter a 4 digit number to decrypt: ");
            var decryption = Console.ReadLine();

            Decryption dnum = new Decryption(decryption);
            Console.WriteLine("The number {0} is decrypted to {1}", decryption, dnum.DecryptedNumber());



            Console.ReadLine();
        }
    }
}

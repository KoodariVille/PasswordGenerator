using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Security.Cryptography.RNGCryptoServiceProvider;
using System.Security.Cryptography;

namespace PasswordGenerator
{
    class Program
    {
        private static RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();

        static void Main(string[] args)
        {
            int num;

            //ask user for the password amount
            Write("Give amount of passwords you want: ");
            bool input = int.TryParse(ReadLine(), out num);

            if (input)
            {
                //calling print/passwordgenerator
                PasswordPrint(num);
            }
            else
            {
                throw new ArgumentException("Wrong type of input input.");//if input isn´t suitable respond is given
            }

            ReadKey();
        }

        //method for printing passwords
        static void PasswordPrint(int num)
        {
            int length; //password length

            Write("Give password length: ");
            bool input = int.TryParse(ReadLine(), out length);

            if (input)
            {
                //loop for printing password given amount
                for (int i = 0; i < num; i++)
                {
                    WriteLine(RandomPassword(length));
                }
            }
            else
            {
                throw new ArgumentException("Wrong type of input input.");//if input isn´t suitable respond is given
            }
        }

        public static byte RandomPassword(int length)
        {
            byte[] randomNumber = new byte[1];
            rngCsp.GetBytes(randomNumber);

            return (byte)(randomNumber[0]);
        }
    }
}

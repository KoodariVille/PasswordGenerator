using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PasswordGenerator
{
    class Program
    {
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
                //if input isn´t suitable respond is given
                WriteLine("Wrong type of input.");
            }
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
                //if input isn´t suitable respond is given
                WriteLine("Wrong type of input.");
            }
        }

        static string RandomPassword(int length)
        {
            Random random = new Random();
            const string pool = "abcdefghijklmnopqrstuvwxyz0123456789";
            var chars = Enumerable.Range(0, length)
                .Select(x => pool[random.Next(0, pool.Length)]);
            return new string(chars.ToArray());
        }
    }
}

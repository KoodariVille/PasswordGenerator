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
            //loop for printing password given amount
            for(int i = 0; i < num; i++)
            {

            }
        }
    }
}

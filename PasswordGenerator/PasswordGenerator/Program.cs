using System;
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
                //calling print method from object
                PassGen.PasswordPrint(num);
            }
            else
            {
                throw new ArgumentException("Wrong type of input input.");//if input isn´t suitable respond is given
            }

            ReadKey();
        }       
    }
}

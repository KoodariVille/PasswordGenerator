﻿using System;
using static System.Console;
using System.Security.Cryptography;

namespace PasswordGenerator
{
    class PassGen
    {
        //characters that are used in generating password
        static readonly char[] AvailableCharacters = {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
            'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '-', '_'
         };

        //method for printing passwords to txt file
        public static void PasswordPrint(int num)
        {
            int length; //password length
            const string path = @"C:\temp\passlist.txt"; //file destination
            string[] passwords = new string[num]; //array where we collect passwords before writing

            Write("Give password length: ");
            bool input = int.TryParse(ReadLine(), out length);

            if (input)
            {
                //loop for printing password given amount
                for (int i = 0; i < num; i++)
                {
                    passwords[i] += GeneratePassword(length);
                }

                //writing passwords to txt file
                System.IO.File.WriteAllLines(path, passwords);
                WriteLine("Passwords have been generated.");
            }
            else
            {
                throw new ArgumentException("Wrong type of input input.");//if input isn´t suitable respond is given
            }
        }

        internal static string GeneratePassword(int length)
        {
            //creating char and byte tables with lengths as parameter
            char[] identifier = new char[length];
            byte[] randomData = new byte[length];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(randomData);
            }

            //generating random possible choises from available characters one by one for the given length
            for (int idx = 0; idx < identifier.Length; idx++)
            {
                int pos = randomData[idx] % AvailableCharacters.Length;
                identifier[idx] = AvailableCharacters[pos];
            }

            //returning generated password
            return new string(identifier);
        }
    }
}

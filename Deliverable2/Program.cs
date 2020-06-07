using System;
using System.Globalization;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string message = "";
            int checksum = 0;

            Console.WriteLine("What is your message?");
            input = Console.ReadLine();
            input = input.ToUpper();



            for(int i = 0; i < input.Length; i++)
            {
                int uni = input[i];
                checksum += uni;

                uni -= 64;
                string temp = uni.ToString();
                message += temp;

                if (!(i == input.Length - 1))
                {
                    message += "-";
                }


            }
           
            Console.WriteLine("\nYour encoded message is: " + message);
            Console.WriteLine("Message checksum is: " + checksum);
        }
    }
}

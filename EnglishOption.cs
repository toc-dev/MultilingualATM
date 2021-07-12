using System;
using System.Collections.Generic;
using System.Text;

namespace MultilingualATM
{
    class EnglishOption
    {
        public static void atmService()
        {
            //var cardNumber = "01234567890";
            var pinNumber = "2021";
            var fullName = "Jonathan Doe";
            int amount = 50000;

            Console.WriteLine("Welcome {0}. Please input your pin", fullName);
            var atmPin = Console.ReadLine();

            if (atmPin == pinNumber)
            {
                Console.WriteLine("please select amount");
                var amountSelected = Convert.ToInt32(Console.ReadLine());

                if (amountSelected <= amount)
                {
                    Console.WriteLine("Please take your cash");
                    amount = amount - amountSelected;
                }
                else
                {
                    Console.WriteLine("Insufficient funds!");
                }
            }
            else
            {
                Console.WriteLine("Wrong pin. Please try again.");
            }
        }
        
    }
}

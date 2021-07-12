using System;
using System.Collections.Generic;
using System.Text;

namespace MultilingualATM
{
    public static class ATMApp
    {
        public static void Run()
        {
            var menu = new StringBuilder();
            menu.Append("Hello, welcome to XYZ bank \n");
            menu.AppendLine("Please insert your card: ");
            Console.WriteLine(menu.ToString());
            var cardNumber = Console.ReadLine();

            Console.WriteLine("Please choose your language: \n 1. English \n 2. Igbo \n 3. Pigin");
            var language = Console.ReadLine();
            if (language != "1" && language != "2" && language != "3")
            {
                Console.WriteLine("INVALID LANGUAGE SELECTION!!!");
            }
            var selectedLanguage = LanguageSelection(language);

            if (language == "1")
            {
                EnglishOption.atmService(); // I will call the method here
                //Console.WriteLine("Enter your pin");
                //var pinNumber = Console.ReadLine();

                //Console.WriteLine();

            }

            
        }

        public static Language LanguageSelection(string language)
        {
            switch (language)
            {
                case "1":
                    return Language.English;
                case "2":
                    return Language.Igbo;
                case "3":
                    return Language.Pidgin;
                default:
                    return Language.SelectLanguage;
            }
        }
    }
    
}

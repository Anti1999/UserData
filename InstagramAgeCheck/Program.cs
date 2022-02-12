using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja vanust;
            //Programm kontrollib, kas kasutaja on vanem, kui 13 või 13 aastane;
            //kui kasutaja on 13 aastat vana või vanem, siis ta võib Instagrami kasutada 
            //kui kasutaja on noorem , kui 13, siis ta on liiga noor.

            Console.WriteLine("Palun, sisestage oma vanus:");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge > 13)
            {
                Console.WriteLine("Oled piisavalt vana, et  Instagramis konto luua");
            }
            else if (userAge < 13)
            {
                Console.WriteLine("Oled liiga noor, et Instagramis konto luua.");
            }
            else
            {
                Console.WriteLine("Oled piisavalt vana, et Instagramis konto luua.");
            }
            Console.WriteLine("Ilusat päeva!");












        }
    }
}

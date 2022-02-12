using System;

namespace Driverlicense
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja sünniaastat
            // programm arvutab kasutaja vanust
            //kui kasutaja on noorem, kui 18, siis programm kuvab konsoolis
            //"oled liiga noor, et juhilube saada";
            //kui kasutaja on vanem, kui 18, siis programm kuvab konsoolis
            //" oled piisavalt vana , et juhilube saada";
            // kui kasutaja on 18, siis programmm kuvab konsoolis
            //"Palju õnne! Nüüd saate juhiluba taodelda!;

            Console.WriteLine("Palun sisestage oma sünniaasta");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2021 - yearOfBirth;
           

            if (userAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et  juhilube saada");
            }
            else if (userAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhilube saada.");
            }
            else
            {
                Console.WriteLine("Palju õnne! Nüüd saate juhiluba taodelda!");
            }
            Console.WriteLine("Ilusat päeva!");




        }
    }
}

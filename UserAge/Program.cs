using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja vanust;
            //Programm arvutab kasutaja sünniaasta;
            //Programm kuvab kasutaja sünniaasta konsoolis;
            // Oled sündinud aastal {yearOfBirth};

            Console.WriteLine("Palun, sisestage oma vanus: ");

            int userAge = Convert.ToInt32(Console.ReadLine());

            int yearOfBirth = 2021 - userAge;

            Console.WriteLine("Oled sündinud aastal " + yearOfBirth);





        }
    }
}

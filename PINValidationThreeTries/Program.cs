using System;

namespace PINValidationThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {

            //programm küsib kasutajal sisestada oma PIN-koodi
            //programm võrdleb sisestatud PIN-koodi arvuga 1234
            //kui sisestatud PIN-kood on 1234,
            //programm kuvab konsoolis "Tere tulemast!
            //kui sisestatud PIN on vale, programm kuvab konsoolis
            //"Vale PIN. Proovi uuesti"
            //kasutajal on kolm katset

            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Sisesta oma PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());
                if (userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }  
                else
                {
                    Console.WriteLine("vale PIN! Proovi uuesti!");
                }   

                
            }
            Console.WriteLine("Kena päeva!");



        }
    }
}

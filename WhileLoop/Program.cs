using System;

namespace WhileLoop
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
            //*katsetearv on piiramatu
            bool loopActive = true;
            //boolean --> true/false
            
            while (loopActive)
            {
                Console.WriteLine("Sisesta oma PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    loopActive = false;
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

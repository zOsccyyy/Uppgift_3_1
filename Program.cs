using System;


namespace Uppgft_3_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());
            if (ålder <= 15)
            {
                Console.WriteLine("Du är för ung");
            }
            else if (ålder >= 20)
            {
                Console.WriteLine("Du är för gammal");

            }
            else
            {
                Console.WriteLine("Du får delta i tävlingen");
            }

   
    
             
            
             
        

        }
    }
}


    








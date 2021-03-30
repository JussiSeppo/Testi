using System;

namespace ArvaaLukuPeli
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Arvaa numero:");  

            int random = new Random().Next(1, 11)
            int arvaus;
            int arvauksia = 0;
            Boolean voitto = false;

            while (arvauksia != 3 && voitto != true)
            {
            Console.WriteLine("Arvaa numero 1-10 väliltä:");

            arvauksia++;

                var arvaus = Console.ReadLine();

                if (validateInput())
                
            }

  }
}



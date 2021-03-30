using System;

namespace ArvaaLukuPeli
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.WriteLine("Arvaa luku:");  

        Random rand = new Random();
        int oikea = rand.Next(1, 11);
        Console.WriteLine(oikea);

        Console.WriteLine("Peli on päättynyt");
                
        }

    }
}



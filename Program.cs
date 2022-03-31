using System;

namespace ConsoleApp34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Search = true;
            while (Search)
            {
                Console.WriteLine("1.Maşınları millage - e göre filtirlə");
                Console.WriteLine("2.Butun masinlari goster");
                Console.WriteLine("3. Prosesi bitir");

                string answer = Console.ReadLine();

                if(answer=="3")
                {
                    Search = false;
                    Console.WriteLine("Prosesi bitir.");
                }
                else
                {
                    Console.WriteLine("Zehmet olmasa duzgun secim edin");
                }
            }
        }
    }
}

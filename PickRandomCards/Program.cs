using System;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Number Of Cards To Pick : ");
            string line = Console.ReadLine();
            if (int.TryParse(line,out int numberOfCards))
            {
                foreach (string card  in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                Console.WriteLine("Plz Enter A Valid Number : ");
            }
            Console.ReadLine();
        }
        
    }
}

using System;

namespace Semana2
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            deck.print();

            bool deckEmpty = deck.Empty;

            Console.WriteLine("Deck Empty: " + deckEmpty);

            Console.WriteLine("Hello World!");
        }
    }
}

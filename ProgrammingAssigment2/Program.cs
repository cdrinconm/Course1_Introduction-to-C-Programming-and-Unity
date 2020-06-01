using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// Programming Assignment 2 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Deals 2 cards to 3 players and displays cards for players
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // print welcome message
            Console.WriteLine("Hi! We are going to play BACKJACK!");
            // create and shuffle a deck
            Deck deck = new Deck();
            deck.Shuffle();
            // deal 2 cards each to 3 players (deal properly, dealing
            // the first card to each player before dealing the
            // second card to each player)
            Card firstPlayerCard1 = deck.TakeTopCard();
            Card secondPlayerCard1 = deck.TakeTopCard();
            Card thirdPlayerCard1 = deck.TakeTopCard();
            Card firstPlayerCard2 = deck.TakeTopCard();
            Card secondPlayerCard2 = deck.TakeTopCard();
            Card thirdPlayerCard2 = deck.TakeTopCard();
            // flip all the cards over
            firstPlayerCard1.FlipOver();
            secondPlayerCard1.FlipOver();
            thirdPlayerCard1.FlipOver();
            firstPlayerCard2.FlipOver();
            secondPlayerCard2.FlipOver();
            thirdPlayerCard2.FlipOver();    
            Console.WriteLine();
            // print the cards for player 1
            Console.WriteLine("First Card Player 1: " + firstPlayerCard1.Rank + " of " + firstPlayerCard1.Suit);
            Console.WriteLine("Second Card Player 1: " + firstPlayerCard2.Rank + " of " + firstPlayerCard2.Suit);
            Console.WriteLine();
            // print the cards for player 2
            Console.WriteLine("First Card Player 2: " + secondPlayerCard1.Rank + " of " + secondPlayerCard1.Suit);
            Console.WriteLine("Second Card Player 2: " + secondPlayerCard2.Rank + " of " + secondPlayerCard2.Suit);
            Console.WriteLine();
            // print the cards for player 3
            Console.WriteLine("First Card Player 3: " + thirdPlayerCard1.Rank + " of " + thirdPlayerCard1.Suit);
            Console.WriteLine("Second Card Player 3: " + thirdPlayerCard2.Rank + " of " + thirdPlayerCard2.Suit);
            Console.WriteLine();
        }
    }
}

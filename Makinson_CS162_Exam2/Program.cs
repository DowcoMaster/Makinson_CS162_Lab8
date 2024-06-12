using CardClasses;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("We are now doing the Card sorting test");
        List <Card> cards = new List<Card>
        {
            new Card(4, 2),
            new Card(5, 3),  
            new Card(13, 1), 
            new Card(10, 2), 
            new Card(2, 2)   
        };

        Console.WriteLine("Before sorting Cards:");
        foreach (Card card in cards)
        {
            Console.WriteLine(card);
        }

        cards.Sort();

        Console.WriteLine("\nAfter sorting Cards:");
        foreach (Card card in cards)
        {
            Console.WriteLine(card);
        }
        Console.WriteLine("\nWe are now looping through the hand after adding cards to it");

        Hand hand = new Hand();
        hand.AddCard(new Card(4, 2));
        hand.AddCard(new Card(2, 4));
        hand.AddCard(new Card(1, 1));
        hand.AddCard(new Card(2, 2));
        hand.AddCard(new Card(3, 4));

        foreach(Card c in hand)
        {
            Console.WriteLine(c);
        }
    }
}
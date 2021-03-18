using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2OOP
{
    class Deck
    {
        // use stack as it relates to how deck of cards works
        public List<string> cards { get; private set; } = new List<string>();

        public Deck()
        {
            FillDeck();
        }

        private void FillDeck()
        {
            Card setOfCards = new Card();
            foreach(string card in setOfCards.GetSetOfCards())
            {
                cards.Add(card);
            }
        }

        public bool isEmpty()
        {
            if(cards.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Shuffle()
        {
            // Use Guid to shuffle the list
            //cards = cards.OrderBy(x => Guid.NewGuid()).ToList();

            // Or use more common way to shuffle
            Random rnd = new Random();
            int count = cards.Count;
            
            while(count > 1)
            {
                count--;
                int rng = rnd.Next(count);
                var value = cards[rng];
                cards[rng] = cards[count];
                cards[count] = value;
            }
        }

        // Keep an index of the top card of the deck
        private int topCardIndex = 51;
        public string Deal()
        {
            // Mark sure the deck isnt empty
            if(cards.Count > 0)
            {
                // Get card at top and return it and decrease topCardIndex
                var topCard = cards[topCardIndex];
                topCardIndex--;
                return topCard.ToString();
            }
            else
            {
                return "No more cards left in deck!";
            }
        }

        public void DisplayDeck()
        {
            foreach(var card in cards)
            {
                Console.WriteLine(card);
            }
        }
    }
}

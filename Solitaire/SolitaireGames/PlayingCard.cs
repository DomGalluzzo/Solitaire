using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apex.MVVM;

namespace Solitaire.SolitaireGames
{
    public class PlayingCard : ViewModel
    {
        public CardSuit Suit
        {
            get
            {
                CardType cardType = new();
                int enumValue = (int)cardType;
                if (enumValue < 13) { return CardSuit.Hearts; };

                if (enumValue < 26) { return CardSuit.Diamonds; };

                if (enumValue < 39) { return CardSuit.Clubs; };

                return CardSuit.Spades;
            }
        }

        public int Value
        {
            get
            {
                CardType cardType = new();
                return ((int)cardType) % 13;
            }
        }

        public CardColor Color
        {
            get
            {
                CardType cardType = new();
                return ((int)cardType) < 26 ? CardColor.Red : CardColor.Black;
            }
        }
    }
}

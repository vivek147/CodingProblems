using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAppCoin
{
    class TestDesign
    {
        //game of playing cards



    }

    public class Cards
    {
        public SuitType Suit;
        public int Denominations;

        public Cards(SuitType suit , int denominations)
        {
            Denominations = denominations;
            Suit = suit;
        }

        public void StartGame(GameType gametype)
        {
            if(gametype == GameType.Rummy)
            {
                RummyGame rummy = new RummyGame();
                rummy.Start(Suit, Denominations);
            }
        }

    }


    public class Games
    {

    }
    public class RummyGame : Games
    {
        internal void Start(SuitType suit, int denominations)
        {
            throw new NotImplementedException();
        }
    }

    public class TeenPatti : Games
    {

    }

    public enum GameType
    {
        Rummy,
        Theenpatti,
    }

    public class GameCreator
    {

    }

    public enum SuitType
    {
        Clubs,
        Hearts,
        Dimonds,
        Spade
    }

}

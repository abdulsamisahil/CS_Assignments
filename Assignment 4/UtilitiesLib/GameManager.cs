using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;


namespace UtilitiesLib 
{

    public delegate void PlayerHitHandler(GameCardLib.Player player);
    public delegate GameCardLib.Player NextPlayerHandler(GameCardLib.Player player);
    public delegate void ShuffleDeckHandler();
    public delegate GameCardLib.Player SendDealerHandler();
    public delegate GameCardLib.Player ReturnFirstPlayerHandler();


     

    public class GameManager 
    {
        

        private GameCardLib.Deck deck;
        private List<GameCardLib.Player> listOfPlayers;
        private GameCardLib.Player Dealer;
        private int _nbrOfDecks;
        private Rules rules;

        public GameManager()
        {

            //Sami är bäst
            //handler 
        }

        /// <summary>
        /// Construct the gamelogics with number of players and decks.
        /// </summary>
        /// <param name="nbrOfDecks"></param>
        /// <param name="nbrOfPlayers"></param>
        public GameManager(int nbrOfDecks,int nbrOfPlayers)
        {
            this._nbrOfDecks = nbrOfDecks;
            deck = new GameCardLib.Deck(_nbrOfDecks);
            CreateNewGame(nbrOfPlayers);
            rules = new Rules();
            DealTwoFirstCards();
        }

       
        
        /// <summary>
        /// Initializes the Dealer and the list of players.
        /// </summary>
        /// <param name="nbrOfPlayers"></param>
        private void CreateNewGame(int nbrOfPlayers)
        {
            Dealer = new GameCardLib.Player(0, "Dealer");
            listOfPlayers = new List<GameCardLib.Player>();

            for (int i = 1; i <= nbrOfPlayers; i++)
            {
                listOfPlayers.Add(new GameCardLib.Player(i, "Player_" + i));
            }
        }

        /// <summary>
        /// Deals 2 cards to each player and dealer.
        /// </summary>
        private void DealTwoFirstCards()
        {
            Dealer.AddCard(deck.DealCard());
            Dealer.AddCard(deck.DealCard());
            rules.dealerHand(Dealer);
            
            for(int i = 0; i < listOfPlayers.Count; i++)
            {
                listOfPlayers[i].AddCard(deck.DealCard());
                listOfPlayers[i].AddCard(deck.DealCard());
                rules.CheckHand(listOfPlayers[i]);
            }
        }

        /// <summary>
        /// Checks if all players are finnished and wants to see dealers hand
        /// </summary>
        /// <returns></returns>
        public bool AllPlayersIsFinnished()
        {
            for (int i = 0; i < listOfPlayers.Count; i++)
            {
                if (listOfPlayers[i].IsFinished == false)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// returns the first player in the list.
        /// </summary>
        /// <returns></returns>
        public GameCardLib.Player sendFirstPlayer()
        {
            return listOfPlayers[0]; 
        }

        /// <summary>
        /// returns the dealer
        /// </summary>
        /// <returns></returns>
        public GameCardLib.Player sendDealer()
        {
            return Dealer;
        }

        /// <summary>
        /// method to reset player values and dealer for a new deal
        /// </summary>
        public void startNewDeal()
        {
            Dealer.ClearHand();
            Dealer.Reset();
            for (int i = 0; i < listOfPlayers.Count; i++)
            {
                listOfPlayers[i].ClearHand();
                listOfPlayers[i].Reset(); 
            }
            DealTwoFirstCards();
        }

        /// <summary>
        /// returns next player, e.g if a player hits the stand button
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public GameCardLib.Player NextPlayer(GameCardLib.Player player)
        {
            if (player.PlayerID >= listOfPlayers.Count)
            {
                return null;
            }
            else
            return listOfPlayers[player.PlayerID];
        }

        /// <summary>
        /// when the hit button is pressed, the player recieves a card.
        /// </summary>
        /// <param name="player"></param>
        public void PlayerHits(GameCardLib.Player player)
        {
            player.AddCard(deck.DealCard());
            rules.CheckHand(player);
        }

        /// <summary>
        /// if dealer is not finnished he recieves another card
        /// </summary>
        public void DealersTurn()
        {
            if(!Dealer.IsFinished )
            {
                Dealer.AddCard(deck.DealCard());
                rules.dealerHand(Dealer);
            }
        }

        /// <summary>
        /// shuffles the deck
        /// </summary>
        public void ShuffleDeck()
        {
            deck.Shuffle();
        }
        
        /// <summary>
        /// return the number of cards left in deck
        /// </summary>
        /// <returns></returns>
        public int cardsLeftInDeck()
        {
            return deck.counter();
        }

        public string Results()
        {

            string result = "" + "";
            
            for (int i = 0; i < listOfPlayers.Count; i++)
            {
                result += rules.Results(listOfPlayers[i], Dealer) + "\n";
            }

            saveResults();

            return result;
        }

        public void saveResults()
        {

            var results = new Dictionary<GameCardLib.Player, bool>();

            results.Add(Dealer, false);

            foreach (GameCardLib.Player player in listOfPlayers)
            {
                results.Add(player, false);
            }


            
            var playerOrderdByHandValue = results.Keys.OrderBy(player => player.HandValue()).Reverse();

            int highestValue = -1;

            foreach (var player in playerOrderdByHandValue)
            {
                if (!player.IsThick) 
                {
                    if (highestValue == -1)
                    {
                        results[player] = true;

                        highestValue = player.HandValue();
                    }
                    else if (player.HandValue() == highestValue)
                    {
                        results[player] = true; 
                    }
                }
            }


            // Saving to database
            using (var db = new Database.BJContext())
            {
                GameCardLib.Player player1 = null;

                foreach (GameCardLib.Player player in results.Keys) 
                { 
                    if (results[player])
                    {

                        player1 = player;
                    }
                }

                var playersDb = results.Keys.ToList().Select(gameCardLibPlayerToPlayerDb).ToList();

                db.saveRound(playersDb, gameCardLibPlayerToPlayerDb(player1));

                db.SaveChanges();
            };
        }

        private Database.Player gameCardLibPlayerToPlayerDb(GameCardLib.Player player)
        {

            var playerDb = new Database.Player();

            playerDb.score = player.HandValue();

            playerDb.name = player.Name;

            return playerDb;
        }
    }
}

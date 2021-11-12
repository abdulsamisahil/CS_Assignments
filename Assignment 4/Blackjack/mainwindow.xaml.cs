﻿using Blackjack.Controls;
using Blackjack.Database;
using GameCardLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UtilitiesLib;

namespace Blackjack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<PlayerPanel> PlayerPanels { get; set; }
        public Manager GameManager { get; set; }
        private Player CurrentPlayer { get; set; }


        ResultDbContex db = new ResultDbContex(); 

        public MainWindow()
        {
            PlayerPanels = new List<PlayerPanel>();
            GameManager = new Manager();
            InitializeComponent();
        }

        private void BtnNewGame_Click(object sender, RoutedEventArgs e)
        {
            ResetWindow();
            NewGameWindow ngw = new NewGameWindow(this);
            ngw.ShowDialog();
            (Player dealer, List<Player> players) = ngw.StartingPlayers;

            PlayerPanel dealerPanel = new PlayerPanel(dealer);
            players.ForEach(p => PlayerPanels.Add(new PlayerPanel(p)));

            DealerSection.Children.Add(dealerPanel);
            Player firstPlayer = GameManager.ContinueRound(ShowWinner);

            if (firstPlayer != null)
            {
                PlayerSection.Children.Add(
                    PlayerPanels.FirstOrDefault(p => p.Player.PlayerId == firstPlayer.PlayerId));
            }
            LabelNbrOfDecks.Content = $"Decks: {GameManager.Deck.Multiplier}";
        }
        //TODO: Change so message is not shown if game is not started
        private void BtnShuffle_Click(object sender, RoutedEventArgs e)
        {
            GameManager.Shuffle(ShowGameNotStarted);
            MessageBox.Show("Cards are shuffled!");

        }

        private void BtnHit_Click(object sender, RoutedEventArgs e)
        {
            if (GameManager.State == GameState.Ongoing)
            {
                CurrentPlayer = PlayerSection.Children.OfType<PlayerPanel>().FirstOrDefault().Player;
                GameManager.Hit(CurrentPlayer.PlayerId, ShowGameNotStarted, ShowLessThanQuarterLeft, ShowPlayerIsThick);
                PlayerSection.Children.OfType<PlayerPanel>().FirstOrDefault().UpdateContent(CurrentPlayer);
                Player nextPlayer = GameManager.ContinueRound(ShowWinner);
                UpdatePlayerSection(nextPlayer);

            }
            else
            {
                ShowGameNotStarted();
            }
        }

        private void BtnStand_Click(object sender, RoutedEventArgs e)
        {
            if (GameManager.State == GameState.Ongoing)
            {
                CurrentPlayer = PlayerSection.Children.OfType<PlayerPanel>().FirstOrDefault().Player;
                GameManager.Stand(CurrentPlayer.PlayerId, ShowGameNotStarted);
                PlayerSection.Children.OfType<PlayerPanel>().FirstOrDefault().UpdateContent(CurrentPlayer);
                Player nextPlayer = GameManager.ContinueRound(ShowWinner);
                UpdatePlayerSection(nextPlayer);       
            }
        }
        
        // Updates the PlayerSection with the next players information, 
        // if there is no next player the current players information is updated
        private void UpdatePlayerSection(Player nextPlayer)
        {
            if (nextPlayer != null && nextPlayer != CurrentPlayer)
            {
                PlayerSection.Children.Clear();
                PlayerSection.Children.Add(
                PlayerPanels.FirstOrDefault(p => p.Player.PlayerId == nextPlayer.PlayerId));
            }
        }

        private void ShowWinner(List<Player> winners, Player dealer)
        {
            DealerSection.Children.OfType<PlayerPanel>().FirstOrDefault().UpdateContent(dealer);
            string winnersStr = "Winner is: ";
            if (!winners.Any())
            {
                winnersStr = "There are no winners in this round.";
            }
            else
            {
                winners.ForEach(w => winnersStr += $"{w.Name} (score: {w.Hand.Score}) ");
            }
            
            LabelWinnerIs.Content = winnersStr;

            string filename = "resultsToXml.save";
            string xml = ResultSerializer<List<Player>>.serializeToXml(winners, filename);
            File.WriteAllText(filename, xml);
            MessageBox.Show("Results are serialized to a xml file");

            //db.Players.ToList(); 
            //db.Add(winners); 
        }

        private void ShowGameNotStarted()
        {
            MessageBox.Show("Game has not started");
        }
        //TODO: Implement functionality
        private void ShowLessThanQuarterLeft()
        {
            MessageBoxResult result = MessageBox.Show("Would you like to shuffle the deck?", "Less than 25 % of the deck is left", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if ( result == MessageBoxResult.Yes)
            {
                GameManager.Shuffle(ShowGameNotStarted);
                MessageBox.Show("Cards are shuffled!");
            }
        }
        private void ShowPlayerIsThick()
        {
            MessageBox.Show("Player is thick!");
        }

        private void ResetWindow()
        {
            DealerSection.Children.Clear();
            PlayerSection.Children.Clear();
            PlayerPanels.Clear();
            CurrentPlayer = null;
            LabelWinnerIs.Content = "Winner is: ";
        }
    }
}

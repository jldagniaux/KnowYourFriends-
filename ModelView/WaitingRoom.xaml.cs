using KnowYourFriends.View;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace KnowYourFriends
{
    /// <summary>
    /// Logique d'interaction pour WaitingRoom.xaml
    /// </summary>
    public partial class WaitingRoom : Window
    {
        public WaitingRoom()
        {
            InitializeComponent();
            DataGridPlayers.ItemsSource = playerlist;
        }
        public class Player //creation d'une classe player qui servira pour créer les joueurs et calculer leur score
        {
            public string Name { get; set; }
            public int YesGuess { get; set; }
            public int Score { get; set; }
        }
        public static int NbPlayersWanted; //cree les variables necessaires
        public static string HostName = "";
        public static int NbPlayers = 1;
        public static int NbRounds;
        public static string ServerName = "";
        public static List<Player> playerlist = new List<Player>();
        public static bool InfoSaved;
        public static int IndexPlayer = 0;

        public void DisplayInfoDataGrid(object sender, EventArgs e) //affiche la grille avec les données des joueurs
        {
            TextBlockServerName.Text = ServerName;
            TextBlockPlayerNumber.Text = "Players : " + NbPlayersWanted;
            TextBlockRoundsNumber.Text = "Rounds : " + NbRounds;
            if (InfoSaved == true)
            {
                playerlist.Add(new Player()
                {
                    Name = HostName,
                    YesGuess = 0,
                    Score = 0
                });
                DataGridPlayers.Items.Refresh();
            }
        }
        private void ButtonSimulation_Click(object sender, RoutedEventArgs e) //cree un joueur pour le mode simulation
        {
            IndexPlayer++;
            NbPlayers++;
            playerlist.Add(new Player()
            {
                Name = "New player" + IndexPlayer,
                YesGuess = 0,
                Score = 0
            });
            DataGridPlayers.Items.Refresh();

            if (NbPlayers == NbPlayersWanted)
            {
                Question toquestion = new Question();
                toquestion.Top = this.Top;
                toquestion.Left = this.Left;
                this.Close();
                toquestion.Show();
            }
        }

        private void ButtonHome_Click(object sender, RoutedEventArgs e)
        {
            IndexPlayer = 0;
            NbPlayers = 1;
            playerlist.Clear();
            MainWindow tohome = new MainWindow();
            tohome.Top = this.Top;
            tohome.Left = this.Left;
            this.Close();
            tohome.Show();
        }
    }
}

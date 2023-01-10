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
    /// Logique d'interaction pour Host.xaml
    /// </summary>
    public partial class Host : Window
    {
        public Host()
        {
            InitializeComponent();
        }

        private void ButtonHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow tomainwindow = new MainWindow();
            this.Close();
            tomainwindow.Show();
        }

        private void ButtonStartServer_Click(object sender, RoutedEventArgs e) //verifie que les infos rentrees sont correctes
        {
            if (int.TryParse(TextBoxPlayerNumber.Text, out int NbPlayers) && NbPlayers > 1 && NbPlayers <= 6 && int.TryParse(TextBoxRoundsNumber.Text, out int NbRounds) && NbRounds >= 1 && NbRounds <= 10 && TextBoxHostName.Text.Length > 0 && TextBoxHostName.Text.Length <= 14 && TextBoxServerName.Text.Length > 0 && TextBoxServerName.Text.Length <= 14)
            {
                WaitingRoom towaitingroom = new WaitingRoom();
                WaitingRoom.NbPlayersWanted = NbPlayers;
                WaitingRoom.HostName = TextBoxHostName.Text;
                WaitingRoom.NbRounds = NbRounds;
                WaitingRoom.ServerName = TextBoxServerName.Text;
                WaitingRoom.InfoSaved = true;
                towaitingroom.Top = this.Top;
                towaitingroom.Left = this.Left;
                this.Close();
                towaitingroom.Show();
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("You entered one of the information incorrectly, please try again.", "Warning");
            }

        }
    }
}

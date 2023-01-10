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

namespace KnowYourFriends.View
{
    /// <summary>
    /// Logique d'interaction pour Heberger.xaml
    /// </summary>
    public partial class Heberger : Window
    {
        public Heberger()
        {
            InitializeComponent();
        }
        private void ButtonHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindowFR tomainwindowfr = new MainWindowFR();
            tomainwindowfr.Top = this.Top;
            tomainwindowfr.Left = this.Left;
            this.Close();
            tomainwindowfr.Show();
        }

        private void ButtonStartServer_Click(object sender, RoutedEventArgs e) //verifie que les infos rentrees sont correctes
        {
            if (int.TryParse(TextBoxPlayerNumber.Text, out int NbPlayers) && NbPlayers > 1 && NbPlayers <= 6 && int.TryParse(TextBoxRoundsNumber.Text, out int NbRounds) && NbRounds >= 1 && NbRounds <= 10 && TextBoxHostName.Text.Length > 0 && TextBoxHostName.Text.Length <= 14 && TextBoxServerName.Text.Length > 0 && TextBoxServerName.Text.Length <= 14)
            {
                SalleAttente towaitingroom = new SalleAttente();
                SalleAttente.NbPlayersWanted = NbPlayers;
                SalleAttente.HostName = TextBoxHostName.Text;
                SalleAttente.NbRounds = NbRounds;
                SalleAttente.ServerName = TextBoxServerName.Text;
                SalleAttente.InfoSaved = true;
                towaitingroom.Top = this.Top;
                towaitingroom.Left = this.Left;
                this.Close();
                towaitingroom.Show();
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Vous avez entré une des informations incrorrectement, veuillez réessayer.", "Warning");
            }

        }
    }
}

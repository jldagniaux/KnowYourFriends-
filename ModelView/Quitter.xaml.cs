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
    /// Logique d'interaction pour Quitter.xaml
    /// </summary>
    public partial class Quitter : Window
    {
        public Quitter()
        {
            InitializeComponent();
        }
        private void ButtonYes_Click(object sender, RoutedEventArgs e) //ferme l'application
        {
            Application.Current.Shutdown();
        }

        private void ButtonNo_Click(object sender, RoutedEventArgs e) //retour au menu accueil
        {
            MainWindowFR tomainwindowfr = new MainWindowFR();
            tomainwindowfr.Top = this.Top;
            tomainwindowfr.Left = this.Left;
            this.Close();
            tomainwindowfr.Show();
        }
    }
}

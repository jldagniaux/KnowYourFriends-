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
    /// Logique d'interaction pour Leave.xaml
    /// </summary>
    public partial class Leave : Window
    {
        public Leave()
        {
            InitializeComponent();
        }

        private void ButtonYes_Click(object sender, RoutedEventArgs e) //ferme l'application
        {
            Application.Current.Shutdown();
        }

        private void ButtonNo_Click(object sender, RoutedEventArgs e) //retour au menu accueil
        {
            MainWindow tomainwindow = new MainWindow();
            this.Close();
            tomainwindow.Show();
        }
    }
}
